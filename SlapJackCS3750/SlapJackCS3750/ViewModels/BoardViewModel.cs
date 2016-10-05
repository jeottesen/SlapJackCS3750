namespace SlapJackCS3750
{
    using Caliburn.Micro;
    using System.Windows;

    public class BoardViewModel : Conductor<object>
    {
        private string cardURL;

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
            CardURL = "/Img/Ace_of_Spades.png";
        }
        
    }
}