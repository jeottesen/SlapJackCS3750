namespace SlapJackGUI.Views
{
    using SlapJack.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using ViewModels;

    /// <summary>
    /// Interaction logic for BoardView.xaml
    /// </summary>
    public partial class BoardView : Window
    {
        
        public BoardView()
        {
            InitializeComponent();
            
        }

        private void Slap(object sender, KeyEventArgs e)
        {
            BoardViewModel bvm = ((BoardViewModel)DataContext);
            switch (e.Key)
            {
                // Player 1 inputs   
                case Key.Z:
                    bvm.onSlap(1);
                    break;
                case Key.C:
                    bvm.onFlip(1);
                    break;
                //Player 2 inputs
                case Key.OemQuestion:
                    bvm.onSlap(2);
                    break;
                case Key.OemComma:
                    bvm.onFlip(2);
                    break;
            }
        }
    }
}
