using BusinessLayer.Services;
using CommonLayer.Models;
using FluentValidation.Results;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace PresentationLayer.Forms
{
    public partial class usersForm : Form
    {
        private readonly IUserService _userService;
        
        bool isUpdating = false;
        public usersForm(IUserService userService)
        {
            InitializeComponent();
         
            _userService = userService;
            LoadData();
            this.usersDataGrip.Columns["RoleId"].Visible = false;

        }
        public void LoadData()
        {
            usersDataGrip.DataSource = _userService.GetUsers();

            rolComboBox.DataSource = _userService.GetRoles();
            rolComboBox.DisplayMember = "RolelName";
            rolComboBox.ValueMember = "RoleId";
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdating)
                {
                    var user = new User
                    {
                        UserId = (int)usersDataGrip.SelectedRows[0].Cells["UserId"].Value,
                        Name = addUserTextBox.Text,
                        Password = userPasswordTextBox.Text,
                        Email = userMailTextBox.Text,
                        RoleId = Convert.ToInt32(rolComboBox.SelectedValue)
                    };
                    UserValidation userValidation = new UserValidation();
                    ValidationResult result = userValidation.Validate(user);
                    if (!result.IsValid)
                    {
                        DisplayValidateErrors(result);
                        MessageBox.Show("User have don't be updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _userService.UpdateUser(user);
                        isUpdating = false;
                        MessageBox.Show("User Updated Successfully");
                        LoadData();
                        clearData();
                    }
                }
                else
                {
                    var user = new User
                    {
                        Name = addUserTextBox.Text,
                        Password = userPasswordTextBox.Text,
                        Email = userMailTextBox.Text,
                        RoleId = Convert.ToInt32(rolComboBox.SelectedValue)
                    };
                    UserValidation userValidation = new UserValidation();
                    ValidationResult result = userValidation.Validate(user);
                    if (!result.IsValid)
                    {
                        DisplayValidateErrors(result);
                        MessageBox.Show("User have don't be created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _userService.CreateUser(user);
                        MessageBox.Show("User Created Successfully");
                        LoadData();
                        clearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editPermissonBtn_Click(object sender, EventArgs e)
        {
            if (usersDataGrip.SelectedRows.Count > 0)
            {
                addUserTextBox.Text = usersDataGrip.SelectedRows[0].Cells["Name"].Value.ToString();
                rolComboBox.SelectedValue = usersDataGrip.SelectedRows[0].Cells["RoleId"].Value;
                userMailTextBox.Text = usersDataGrip.SelectedRows[0].Cells["Email"].Value.ToString();
                userPasswordTextBox.Text = usersDataGrip.SelectedRows[0].Cells["Password"].Value.ToString();
                isUpdating = true;
            }
            else
            {
                MessageBox.Show("Please select a User to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usersDataGrip.SelectedRows.Count < 1)
                {
                    MessageBox.Show("You have to select a row", "Beware", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var delete = new DialogResult();
                    delete = MessageBox.Show("¿Are you sure to delete an User?", "Beware", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (delete == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(usersDataGrip.SelectedRows[0].Cells["UserId"].Value);
                        _userService.DeleteUser(id);
                        MessageBox.Show("User Deleted Successfully");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayValidateErrors(ValidationResult result)
        {
            userErrorProvider.Clear();
            foreach (var failure in result.Errors)
            {
                switch (failure.PropertyName)
                {
                    case "Name":
                        userErrorProvider.SetError(addUserTextBox, failure.ErrorMessage);
                        break;
                    case "Password":
                        userErrorProvider.SetError(userPasswordTextBox, failure.ErrorMessage);
                        break;
                    case "Email":
                        userErrorProvider.SetError(userMailTextBox, failure.ErrorMessage);
                        break;
                    case "RoleId":
                        userErrorProvider.SetError(rolComboBox, failure.ErrorMessage);
                        break;
                }
            }
        }
        private void clearData()
        {
            addUserTextBox.Text = "";
            userPasswordTextBox.Text = "";
            userMailTextBox.Text = "";
            rolComboBox.SelectedIndex = 0;
        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e)
        {
            usersDataGrip.DataSource = _userService.SearchUser(searchUserTextBox.Text);
            if (searchUserTextBox.Text == "")
            {
                LoadData();
            }
        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
            GeneratePDFAsync();
        }
        private bool showPasswords = false;
        private CheckBox showPasswordsCheckBox;

        private void InitializePasswordControl()
        {
            showPasswordsCheckBox = new CheckBox
            {
                Text = "Show Passwords in PDF",
                Location = new Point(PDFBtn.Left + PDFBtn.Width + 10, PDFBtn.Top),
                AutoSize = true
            };
            this.Controls.Add(showPasswordsCheckBox);
        }
        private async Task GeneratePDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var userList = new List<User>();

                foreach (DataGridViewRow row in usersDataGrip.Rows)
                {
                    if (row.IsNewRow) continue;

                    var user = new User
                    {
                        Name = row.Cells["Name"].Value?.ToString() ?? string.Empty,
                        Password = row.Cells["Password"].Value?.ToString() ?? string.Empty,
                        Email = row.Cells["Email"].Value?.ToString() ?? string.Empty,
                        RolelName = row.Cells["RolelName"].Value?.ToString() ?? string.Empty,
                    };

                    userList.Add(user);
                }

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A3.Landscape());
                        page.Margin(2, Unit.Centimetre);

                        // Enhanced header
                        page.Header().Height(80).DefaultTextStyle(x => x.FontSize(28))
                            .Background(Colors.Blue.Darken3)
                            .Padding(20)
                            .Row(row =>
                            {
                                row.RelativeItem().Text("User Management Report")
                                    .Bold()
                                    .FontColor(Colors.White);

                                row.RelativeItem().AlignRight()
                                    .Text(DateTime.Now.ToString("MMMM dd, yyyy"))
                                    .FontColor(Colors.Grey.Lighten3)
                                    .FontSize(14);
                            });

                        page.Content().PaddingVertical(1, Unit.Centimetre)
                            .Column(column =>
                            {
                                // Summary section
                                column.Item().PaddingBottom(1, Unit.Centimetre)
                                    .Background(Colors.Grey.Lighten4)
                                    .Padding(20)
                                    .Row(row =>
                                    {
                                        row.RelativeItem().Text($"Total Users: {userList.Count}")
                                            .Bold().FontSize(14);
                                        row.RelativeItem().Text($"Report Generated: {DateTime.Now}")
                                            .FontSize(14);
                                    });

                                // Enhanced table
                                column.Item().Table(table =>
                                {
                                    // Column definitions with optimized widths
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(2f);    // Name
                                        columns.RelativeColumn(2f);    // Password
                                        columns.RelativeColumn(3f);    // Email
                                        columns.RelativeColumn(1.5f);  // Role
                                    });

                                    // Enhanced header
                                    table.Header(header =>
                                    {
                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(Colors.Blue.Darken3)
                                            .Padding(10)
                                            .Text("Name")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(12);

                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(Colors.Blue.Darken3)
                                            .Padding(10)
                                            .Text("Password")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(12);

                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(Colors.Blue.Darken3)
                                            .Padding(10)
                                            .Text("Email")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(12);

                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(Colors.Blue.Darken3)
                                            .Padding(10)
                                            .Text("Role")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(12);
                                    });

                                    // Enhanced rows
                                    foreach (var (user, index) in userList.Select((u, i) => (u, i)))
                                    {
                                        var backgroundColor = index % 2 == 0 ? Colors.White : Colors.Grey.Lighten4;

                                        // Name
                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .Text(user.Name)
                                            .FontSize(11);

                                        // Password (masked)
                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .Text("••••••••")
                                            .FontSize(11);

                                        // Email
                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .Text(user.Email)
                                            .FontSize(11);

                                        // Role with color coding
                                        var roleColor = user.RolelName.ToLower() switch
                                        {
                                            "admin" => Colors.Red.Medium,
                                            "manager" => Colors.Blue.Medium,
                                            _ => Colors.Grey.Medium
                                        };

                                        table.Cell().Border(1).BorderColor(Colors.Grey.Darken1)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .Text(user.RolelName)
                                            .FontColor(roleColor)
                                            .Bold()
                                            .FontSize(11);
                                    }
                                });

                                // Footer
                                column.Item().PaddingTop(1, Unit.Centimetre)
                                    .Text(text =>
                                    {
                                        text.Span("Generated by ").FontSize(10);
                                        text.Span("User Management System").Bold().FontSize(10);
                                        text.Span($" • Page 1 of 1").FontSize(10);
                                    });
                            });
                    });
                });

                await Task.Run(() => document.GeneratePdfAndShow());
                MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                PDFBtn.Enabled = true;
                Cursor = Cursors.Default;
            }
        }


    }
}
