namespace SignalRMVC.Models
{
    public enum Suit
    {
        Spade,
        Diamond,
        Club,
        Heart
    }

    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card
    {
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Rank, Suit);
        }
    }
}
