namespace SlapJack.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Deck
    {
        // Creates an array of Card objecs that acts as the deck.
        //Stack<Card> deck = new Stack<Card>();
        List<Card> deck = new List<Card>();
        private static Random rng = new Random();

        // Fills deck with 1 card of each Suit and Face.
        public Deck()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    deck.Add(new Card((Suit)i, (Face)j));
                }
            }
            Shuffle();
        }

        // Pseudo-randomly orders the deck array.
        //public void shuffle()
        //{
        //    Random rnd = new Random();
        //    deck = (Stack<Card>)deck.OrderBy(x => rnd.Next());
        //}

        public void Shuffle()
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }


        // deal the top card from the deck
        public Card deal()
        {
            // returns a card unless the stack is empty then return null
            try
            {
                Card temp = deck[0];
                deck.RemoveAt(0);
                return temp;
            } catch (InvalidOperationException)
            {
                return null;
            }
        }
    }
}
