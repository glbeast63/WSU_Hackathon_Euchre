using System.Collections.Generic;

namespace SignalRMVC.Models
{
    public class Player
    {
        public Player(string name, int id)
        {
            Name = name;
            ID = id;
            Cards = new List<Card>();
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public List<Card> Cards { get; set; }
    }
}
