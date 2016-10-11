namespace SlapJackGUI.ViewModels
{
    using Caliburn.Micro;
    using SlapJack.Models;
    using System;
    using System.Windows;

    public class BoardViewModel : Conductor<object>
    {
        private string cardURL;
        public string CardURL
        {
            get { return cardURL; }
            set
            {
                cardURL = "/Img/" + value + ".png";
                NotifyOfPropertyChange(() => CardURL);

            }
        }

        private Board board;

        private bool gameEnd;

        private int pileCount;

        public int PileCount
        {
            get { return pileCount; }
            set
            {
                pileCount = value;
                NotifyOfPropertyChange(() => PileCount);
            }
        }

        public void onSlap(int playerId)
        {

            bool validSlap = board.playerSlapped(playerId);
            if (validSlap == true)
                CardURL = "";
            updateCounts();
            int winner  = board.checkWinner();
            if (winner != -1)
                displayWinner();
        }


        public void onFlip(int playerId)
        {
            Card card = board.players[0].Flip();
            board.addCard(card);
            board.lastPlayed = 1;
            CardURL = card.ToString();
            updateCounts();
        }

        private void updateCounts()
        {
            PileCount = board.getPileCount();
        }

        private void displayWinner()
        {
            // TODO
        }

        public BoardViewModel()
        {
            board = new Board();
        }
        
    }
}