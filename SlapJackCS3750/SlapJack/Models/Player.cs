namespace SlapJack
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player
    {
        //Properties
        private List<Card> hand;
       
        //constructor
        public Player()
        {
            hand = new List<Card>();
        }


        public Card Flip()
        {
            if (hand.Count > 0)
            {
                Card card = hand[0];
                hand.Remove(card);
                return card;
            } // else player loses

            return null;
        }

        public void receiveCard(Card card)
        {
            // Add to the top of the hand
            if (card != null)
            {
                hand.Insert(0, card);
            }
        }

        public void addToBottom(Card card)
        {
            hand.Add(card);
        }

        public void addToBottom(IEnumerable<Card> cards)
        {
            hand.AddRange(cards);
        }

        public int getHandCount()
        {
            return hand.Count();
        }

    }
}
