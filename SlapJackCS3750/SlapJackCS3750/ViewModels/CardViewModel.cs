namespace SlapJackCS3750.ViewModels
{
    using Caliburn.Micro;

    class CardViewModel : Screen
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

        public CardViewModel()
        {
            CardURL = "/Img/Ace_of_Spades.png";
        }
    }
}
