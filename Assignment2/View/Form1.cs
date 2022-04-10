using Assignment1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Assignment1
{
    public partial class GUI : Form
    {

        private Service.Service service;
        private BindingSource bsTeams;
        private BindingSource bsPlayers;
        private AppConfig config;

        public GUI(AppConfig _config)
        {
            config = _config;
            service = new Service.Service(config);
            InitializeComponent();
            InitializeTeamsGrid();
            InitializePlayersGrid();
        }

        private void InitializePlayersGrid()
        {
            bsPlayers = new BindingSource();
            bsPlayers.DataSource = bsTeams;
            bsPlayers.DataMember = config.keyName;
            playersGrid.DataSource = bsPlayers;
        }

        private void InitializeTeamsGrid()
        {
            bsTeams = new BindingSource();
            bsTeams.DataSource = service.Ds;
            bsTeams.DataMember = config.table1;
            teamsGrid.DataSource = bsTeams;
        }

        private void GUI_Load(object sender, EventArgs e)
        {


        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            service.UpdateDatabase();
        }
    }
}
