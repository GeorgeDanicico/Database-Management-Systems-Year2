using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Model
{
    class Teams
    {
        private int team_id;
        private string team_name;
        private int total_winnings;

        public Teams(int team_id, string team_name, int total_winnings)
        {
            this.team_id = team_id;
            this.team_name = team_name;
            this.total_winnings = total_winnings;
        }

        public int Team_id { get => team_id; set => team_id = value; }
        public string Team_Name { get => team_name; set => team_name = value; }
        public int Total_Winnings { get => total_winnings; set => total_winnings = value; }
    }
}
