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
                    case 'z':
                        Console.WriteLine("Player 1 slapped!");
                        gameEnd = board.playerSlapped(1);
                        if (gameEnd == true)
                            Console.WriteLine("Player 1 Wins!");
                        break;
                    case 'c':
                        card = board.players[0].Flip();
                        board.addCard(card);
                        board.lastPlayed = 1;
                        Console.WriteLine("Player 1 flipped a " + card + " to the top of the pile");
                        break;
                    case '/':
                        Console.WriteLine("Player 2 slapped!");
                        gameEnd = board.playerSlapped(2);
                        if (gameEnd == true)
                            Console.WriteLine("Player 2 Wins!");
                        break;
                    case ',':
                        card = board.players[1].Flip();
                        board.addCard(card);
                        board.lastPlayed = 2;
                        Console.WriteLine("Player 2 flipped a " + card + " to the top of the pile");
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
