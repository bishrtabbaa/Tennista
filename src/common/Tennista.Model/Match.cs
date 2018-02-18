using System;
using System.Collections.Generic;
using System.Text;

namespace Tennista.Model
{
    public class Match
    {
        public Tournament Tournament { get; set; }
        public Player Winner { get; set; }
        public Player Loser { get; set; }
        public string Score { get; set; }
        public float Round { get; set; }
    }
}
