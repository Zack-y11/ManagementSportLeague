using BusinessLayer.Services;
using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                _userService.UpdateUser(user);
                isUpdating = false;
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
                _userService.CreateUser(user);
            }
            LoadData();
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
    }
}
