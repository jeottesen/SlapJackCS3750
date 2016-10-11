namespace SlapJack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player
    {
        //Properties
        private Stack<Models.Card> hand;
        private Models.Board gameBoard;  //Holds an instance of the Board to allow player to flip card onto the pile

        private Boolean _slapped;
        public Boolean slapped
        {
            get { return slapped; }
            set {
                _slapped = slapped;
                }
        }

        //constructor
        public Player(Models.Board board)
        {
            _slapped = false;
            gameBoard = board;
            hand = new Stack<Models.Card>();
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
            if(hand.Count > 0)
            {
                gameBoard.addCard(hand.Pop());
            }
            else
            {
                //player loses
            }
            
        }

        public void receiveCard(Models.Card newCard)
        {
            hand.Push(newCard);
        }
         
    }
}
