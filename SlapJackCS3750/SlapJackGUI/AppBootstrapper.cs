namespace SlapJackCS3750
{
    using Caliburn.Micro;
    using System.Windows;
    using SlapJackGUI.ViewModels;

    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<BoardViewModel>();
        }
        
    }
}
