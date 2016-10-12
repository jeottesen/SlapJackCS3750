namespace SlapJack
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SlapJackCLI
    {

        static void Main(string[] args)
        {
            Boolean gameEnd = false;

            Board board = new Board();

            Console.WriteLine("Hello, Wecome to SlapJack CLI please flip a card.");
            Console.WriteLine("Player " + (3 - board.lastPlayed) + "'s turn");
            //This will loop as long as the game has not ended
            while (!gameEnd)
            {
                /* get the pressed character and convert it to lowercase. Pass true to ReadKey 
                 * to prevent it from outputting the character that was pressed.
                 */
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char pressedKey = char.ToLower(keyInfo.KeyChar);
                
                Card card;
                switch (pressedKey)
                {
                    // Player 1 inputs
                    case 'z':
                        Console.WriteLine("Player 1 slapped!");
                        board.playerSlapped(1);
                        break;
                    case 'c':
                        card = board.playerFlipped(1);
                        if (card != null)
                        {
                            board.addCard(card);
                            Console.WriteLine("Player 1 flipped a " + card + " to the top of the pile");
                        }
                        break;
                    // player 2 inputs
                    case '/':
                        Console.WriteLine("Player 2 slapped!");
                        board.playerSlapped(2);
                        break;
                    case ',':
                        card = board.playerFlipped(2);
                        if (card != null)
                        {
                            board.addCard(card);
                            Console.WriteLine("Player 2 flipped a " + card + " to the top of the pile");
                        }
                        break;
                }

                int winner = board.checkWinner();
                switch (winner)
                {
                    case -1:
                        Console.WriteLine("Player " + (3 - board.lastPlayed) + "'s turn");
                        break;
                    case 1:
                        Console.WriteLine("Player 1 wins!");
                        gameEnd = true;
                        break;
                    case 2:
                        Console.WriteLine("Player 2 wins!");
                        gameEnd = true;
                        break;
                }

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Goodbye");
                    gameEnd = true;
                }
            }
        }
    }
}
