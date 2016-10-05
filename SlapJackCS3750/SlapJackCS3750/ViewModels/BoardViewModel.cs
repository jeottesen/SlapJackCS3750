namespace SlapJackCS3750
{
    using Caliburn.Micro;
    using System.Windows;
    using ViewModels;

    public class BoardViewModel : Conductor<object>
    {
        private CardViewModel cardVM;

        /*
        public CardViewModel CardVM
        {
            get { return cardVM; }
            set
            {
                cardVM = value;
                NotifyOfPropertyChange(() => CardVM);
            }
        }*/
        
        public BoardViewModel()
        {
            cardVM = new CardViewModel();
            ActivateItem(cardVM);
        }
        
    }
}