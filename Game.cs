using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
    All conflicts resolved
*/

namespace ClassLibrary1
{
    public class Game
    {
        public string team1 { get; set; }
        public int team1score { get; set; }
        public string team2 { get; set; }
        public int team2score { get; set; }
        public int counter {get; set; }

        public Game()
        {

        }

        public Game(string team1, int team1score, string team2, int team2score)
        {
            this.team1 = team1;
            this.team1score = team1score;
            this.team2 = team2;
            this.team2score = team2score;
        }

        public override string ToString()
        {
            return team1 + " (" + team1score + ") - " + team2 + " (" + team2score + ")";
        }
    }

    
}
