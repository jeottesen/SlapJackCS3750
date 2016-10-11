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
        private Models.Board gameBoard;  //Holds an instance of the Board to allow player to flip card onto the pile

        //constructor
        public Player(Board board)
        {
            gameBoard = board;
            hand = new List<Card>();
        }

       //Methods
        public void slap()
        {
            // do a boolean and have a while loop on main program(game) that will check each run through until a slap occurs
           // _slapped = true;

            gameBoard.playerSlapped(this);
        }

        public void Flip()
        {
            if (hand.Count > 0)
            {
                
                gameBoard.addCard(getTopCard());
            } // else player loses

        }

        public Card getTopCard()
        {
            Card card = hand[0];
            hand.Remove(card);
            return card;
        }

        public void receiveCard(Card card)
        {
            // Add to the top of the hand
            hand.Insert(0, card);
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
