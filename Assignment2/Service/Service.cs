using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment1.Service
{
    class Service
    {
        private SqlConnection connection;
        private SqlDataAdapter daTeams, daPlayers;
        private SqlCommandBuilder cbPlayers, cbTeams;
        private DataSet ds;
        private AppConfig config;

        public DataSet Ds { get => ds; set => ds = value; }

        public Service(AppConfig _config)
        {
            config = _config;
            connection = new SqlConnection(config.connString);
            ds = new DataSet();
            AddArtists();
            AddPlayers();
            AddRelation();

        }

        private void AddRelation()
        {
            DataRelation dr = new DataRelation(config.keyName, ds.Tables[config.table1].Columns[config.columnFK],
                                            ds.Tables[config.table2].Columns[config.columnFK]);
            ds.Relations.Add(dr);
        }

        private void AddPlayers()
        {
            daPlayers = new SqlDataAdapter(config.query2, connection);
            cbPlayers = new SqlCommandBuilder(daPlayers);
            daPlayers.Fill(ds, config.table2);
        }

        private void AddArtists()
        {
            daTeams = new SqlDataAdapter(config.query1, connection);
            cbTeams = new SqlCommandBuilder(daTeams);
            daTeams.Fill(ds, config.table1);
        }

        public void UpdateDatabase()
        {
            daPlayers.Update(ds, config.table2);
            daTeams.Update(ds, config.table1);
        }
    }
}
