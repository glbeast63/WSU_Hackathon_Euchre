using System;
using System.Collections.Generic;

namespace SignalRMVC.Models
{
    public class EuchreDeck
    {
        private EuchreDeck() { }

        public List<Card> Cards { get; private set; }

        public static EuchreDeck CreateDeck()
        {
            var deck = new EuchreDeck { Cards = new List<Card>() };

            for (var s = 0; s < 4; s++)
                for (var r = 9; r < 15; r++)
                    deck.Cards.Add(new Card((Suit)s, (Rank)r));

            return deck;
        }

        public int Shuffle()
        {
            var seed = Guid.NewGuid().GetHashCode();
            Shuffle(seed);
            return seed;
        }

        public void Shuffle(int seed)
        {
            var randomNumberGenerator = new Random(seed);

            var dupedDeck = new List<Card>(52);
            dupedDeck.AddRange(Cards);

            var count = Cards.Count;
            var cards = new List<Card>();
            while (cards.Count != count)
            {
                var cardToPull = randomNumberGenerator.Next(0, count - cards.Count);
                cards.Add(dupedDeck[cardToPull]);
                dupedDeck.RemoveAt(cardToPull);
            }
            Cards = cards;
        }

        public Card this[int i] => Cards[i];
    }
}
