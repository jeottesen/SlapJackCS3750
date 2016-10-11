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
            bool gameEnd = false;
            Card card;
            switch (e.Key)
            {
                
                case Key.Z:
                    Console.WriteLine("Player 1 slapped!");
                    gameEnd = bvm.Board.playerSlapped(1);
                    if (gameEnd == true)
                        Console.WriteLine("Player 1 Wins!");
                    break;
                case Key.C:
                    card = bvm.Board.players[0].Flip();
                    bvm.Board.addCard(card);
                    bvm.Board.lastPlayed = 1;
                    bvm.CardURL = card.ToString();
                    bvm.PileCount = bvm.Board.getPileCount();
                    bvm.Player1HandCount = bvm.Board.players[0].getHandCount();
                    break;
                case Key.OemQuestion:
                    Console.WriteLine("Player 2 slapped!");
                    gameEnd = bvm.Board.playerSlapped(2);
                    if (gameEnd == true)
                        Console.WriteLine("Player 2 Wins!");
                    break;
                case Key.OemComma:
                    card = bvm.Board.players[1].Flip();
                    bvm.Board.addCard(card);
                    bvm.Board.lastPlayed = 2;
                    bvm.CardURL = card.ToString();
                    bvm.PileCount = bvm.Board.getPileCount();
                    bvm.Player2HandCount = bvm.Board.players[1].getHandCount();
                    break;
            }
        }
    }
}
