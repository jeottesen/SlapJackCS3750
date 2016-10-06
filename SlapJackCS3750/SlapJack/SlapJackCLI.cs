namespace SlapJack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SlapJack.Models;

    /// <summary>
    /// This class is the controller for the cli version of the program
    /// All user inputs and timers should be handled by this class rather
    /// than the Models. This will make it easier to build a GUI on top of
    /// </summary>
    class SlapJackCLI
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Console.WriteLine("This is the top card in the pile " + board.getTopCard());
        }
    }
}