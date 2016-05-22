using System.Collections.Generic;

namespace SignalRMVC.Models
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
            Score = 0;
        }

        public List<Player> Players { get; private set; }
        public int Score { get; set; }
    }
}
