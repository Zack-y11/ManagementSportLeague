using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;
using BusinessLayer.Services;
using CommonLayer.Models;



namespace PresentationLayer.Forms
{

    
    public partial class SettingsForm : Form
    {
   
        public SettingsForm(ITeamService teamService)
        {
          
            InitializeComponent();
        }





       

    }
}




