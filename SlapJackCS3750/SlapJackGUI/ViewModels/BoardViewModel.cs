namespace SlapJackGUI.ViewModels
{
    using Caliburn.Micro;
    using SlapJack.Models;
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

        public Board Board
        {
            get { return board; }
            set
            {
                board = value;
                NotifyOfPropertyChange(() => Board);
            }
        }

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

        private int player1HandCount;

        public int Player1HandCount
        {
            get { return player1HandCount; }
            set
            {
                player1HandCount = value;
                NotifyOfPropertyChange(() => Player1HandCount);
            }

        }

        private int player2HandCount;

        public int Player2HandCount
        {
            get { return player2HandCount; }
            set
            {
                player2HandCount = value;
                NotifyOfPropertyChange(() => Player2HandCount);
            }

        }

        public BoardViewModel()
        {
            board = new Board();
        }
        
    }
}