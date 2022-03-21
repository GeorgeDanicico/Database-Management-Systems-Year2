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
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlDataAdapter daPlayer, daTeam;
        DataSet ds;
        SqlCommandBuilder cb;
        BindingSource bsPlayer, bsTeam;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source = DESKTOP-A8SPPMM; Initial Catalog=DB_COURSE; Integrated Security = True");
            ds = new DataSet();
            daPlayer = new SqlDataAdapter("SELECT * FROM Players", connection);
            daTeam = new SqlDataAdapter("SELECT * FROM Teams", connection);
            cb = new SqlCommandBuilder(daPlayer);

            daPlayer.Fill(ds, "Players");
            daTeam.Fill(ds, "Teams");

            DataRelation dr = new DataRelation("FK_Teams_Players", ds.Tables["Teams"].Columns["team_id"], ds.Tables["Players"].Columns["team_id"]);
            ds.Relations.Add(dr);

            bsPlayer = new BindingSource();
            bsTeam = new BindingSource();

            bsTeam.DataSource = ds;
            bsTeam.DataMember = "Teams";

            bsPlayer.DataSource = bsTeam;
            bsPlayer.DataMember = "FK_Teams_Players";

            playersDataGridView.DataSource = bsPlayer;
            teamsDataGridView.DataSource = bsTeam;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            daPlayer.Update(ds, "Players");
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
/*            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*            // TODO: This line of code loads data into the 'dBDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.dBDataSet.Teams);
            // TODO: This line of code loads data into the 'dBDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.dBDataSet.Players);*/

        }
    }
}
