using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlapJackCS3750.Models
{
    class Deck
    {
        // Creates an array of Card objecs that acts as the deck.
        Stack<Card> deck = new Stack<Card>();

        // Fills deck with 1 card of each Suit and Face.
        public Deck()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    deck.Push(new Card((Suit)i, (Face)j));
                }
            }
            shuffle();
        }

        // Pseudo-randomly orders the deck array.
        public void shuffle()
        {
            Random rnd = new Random();
            deck = (Stack<Card>)deck.OrderBy(x => rnd.Next());
        }

        // deal the top card from the deck
        public Card deal()
        {
            // returns a card unless the stack is empty then return null
            try
            {
                return deck.Pop();
            } catch (InvalidOperationException)
            {
                return null;
            }
        }
    }
}
