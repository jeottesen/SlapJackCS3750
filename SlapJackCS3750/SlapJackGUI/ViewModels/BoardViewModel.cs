namespace SlapJackGUI.ViewModels
{
    using Caliburn.Micro;
    using SlapJack.Models;
    using System.Windows;

    public class BoardViewModel : Conductor<object>
    {
        private string cardURL;

        private Board board;

        public string CardURL
        {
            get { return cardURL; }
            set
            {
                cardURL = value;
                NotifyOfPropertyChange(() => cardURL);
            }
        }


        public BoardViewModel()
        {
            board = new Board();
            CardURL = "/Img/" + board.getTopCard() + ".png";
        }
        
    }
}