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
using SlapJackCS3750.Models;

namespace SlapJackCS3750
{
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
            if(e.Key == Key.Z)
            {
                MessageBox.Show("Player 1 slapped!");
            }
            else if(e.Key == Key.NumPad0)
            {
                MessageBox.Show("Player 2 slapped!");
            }
        }
    }
}
