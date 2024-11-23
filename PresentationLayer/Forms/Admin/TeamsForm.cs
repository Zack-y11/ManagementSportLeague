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

    public partial class TeamsForm : Form
    {
        private readonly ITeamService _teamService;
        bool isUpdating = false;
        public TeamsForm(
            ITeamService teamService
            )
        {
            InitializeComponent();
            _teamService = teamService;
            LoadData();
            this.activeTeamsDataGrip.Columns["ManagerId"].Visible = false;
            //this.activeTeamsDataGrip.Columns["TeamId"].Visible = false;
        }
        public void LoadData()
        {
            activeTeamsDataGrip.DataSource = _teamService.GetTeams();
            coachComboBox.DataSource = _teamService.GetManagers();
            coachComboBox.DisplayMember = "Name";
            coachComboBox.ValueMember = "UserId";
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdating)
                {
                    Team team = new Team
                    {
                        ManagerId = (int)coachComboBox.SelectedValue,
                        TeamName = teamNameTextBox.Text,
                        Wins = int.Parse(winsTextBox.Text),
                        Loses = int.Parse(loosesTextBox.Text),
                        Points = int.Parse(pointsTextBox.Text),
                        TeamId = (int)activeTeamsDataGrip.CurrentRow.Cells["TeamId"].Value
                    };
                    _teamService.UpdateTeam(team);
                    isUpdating = false;
                    LoadData();
                }
                else
                {
                    var team = new Team
                    {
                        ManagerId = int.Parse(coachComboBox.SelectedValue.ToString()),
                        TeamName = teamNameTextBox.Text,
                        Wins = 0,
                        Loses = 0,
                        Points = 0
                    };
                    _teamService.AddTeam(team);
                    LoadData();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Uno de los valores proporcionados es nulo: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Operación inválida: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }

        private void editTeamBtn_Click(object sender, EventArgs e)
        {
            if (activeTeamsDataGrip.SelectedRows.Count > 0)
            {
                teamNameTextBox.Text = activeTeamsDataGrip.CurrentRow.Cells["TeamName"].Value.ToString();
                coachComboBox.SelectedValue = activeTeamsDataGrip.SelectedRows[0].Cells["ManagerId"].Value;
                winsTextBox.Text = activeTeamsDataGrip.SelectedRows[0].Cells["Wins"].Value.ToString();
                loosesTextBox.Text = activeTeamsDataGrip.SelectedRows[0].Cells["Loses"].Value.ToString();
                pointsTextBox.Text = activeTeamsDataGrip.SelectedRows[0].Cells["Points"].Value.ToString();
                isUpdating = true;
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para editar");
            }
        }

        private void deleteTeamBtn_Click(object sender, EventArgs e)
        {
            if (activeTeamsDataGrip.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = new DialogResult();
                delete = MessageBox.Show("¿Está seguro de que desea eliminar este equipo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    int id= Convert.ToInt32(activeTeamsDataGrip.CurrentRow.Cells["Id"].Value);
                    _teamService.DeleteTeam(id);
                    LoadData();
                }
            }
        }
    }
}
