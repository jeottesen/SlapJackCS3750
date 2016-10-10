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

            //This will loop as long as the game has not ended
            while (!gameEnd)
            {
                /* get the pressed character and convert it to lowercase. Pass true to ReadKey 
                 * to prevent it from outputting the character that was pressed.
                 */
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char pressedKey = char.ToLower(keyInfo.KeyChar);

                switch (pressedKey)
                {
                    case 'z':
                        Console.WriteLine("Player 1 slapped!");
                        // TODO call player 1 slap
                        // Change gameEnd if a player won
                        break;
                    case 'c':
                        Console.WriteLine("Player 1 flipped!");
                        // TODO call player 1 flip
                        break;
                    case '/':
                        Console.WriteLine("Player 2 slapped!");
                        // TODO call player 2 slap
                        // Change gameEnd if a player won
                        break;
                    case ',':
                        Console.WriteLine("Player 2 flipped!");
                        // TODO call player 2 flip
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
