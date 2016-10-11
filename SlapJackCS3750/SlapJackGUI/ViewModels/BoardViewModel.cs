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



        public BoardViewModel()
        {
            board = new Board();
        }
        
    }
}