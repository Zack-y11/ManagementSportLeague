using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.ManagerForms
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ibtnMaximizar.Visible = false;
            ibtnRestaurar.Visible = true;
        }

        private void ibtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ibtnRestaurar.Visible = false;
            ibtnMaximizar.Visible = true;
        }
    }
}
