using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Model
{
    class Players
    {
        private int player_id;
        private string first_name;
        private string last_name;
        private int age;
        private string nickname;
        private int team_id;

        Players(int pid, string fn, string ln, int age, string nn, int tid)
        {
            this.player_id = pid;
            this.first_name = fn;
            this.last_name = ln;
            this.age = age;
            this.nickname = nn;
            this.team_id = tid;
        }

        public int Player_id { get => player_id; set => player_id = value; }
    }
}
