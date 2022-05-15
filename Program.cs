using System.Threading;
using System;

class ChessClock
{
    private static int millisecondPrecision = 100;
    private static int millisecondsPerPlayer = 10 * 60 * 1000; // 10 minutes

    private static int millisecondsPlayerOne = millisecondsPerPlayer;
    private static int millisecondsPlayerTwo = millisecondsPerPlayer;

    public static void Main(string[] args)
    {
        bool isPlayerOne = true;
        gameLoop(isPlayerOne);
    }

    private static void gameLoop(bool isPlayerOne)
    {
        while (true)
        {
            // the current players time!
            var playerTime = isPlayerOne ? millisecondsPlayerOne : millisecondsPlayerTwo;

            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(millisecondPrecision);
                
                if (isPlayerOne) {
                    millisecondsPlayerOne -= 100;
                }
                else {
                    millisecondsPlayerTwo -= 100;

                }
                Console.WriteLine( $"P2: {millisecondsPlayerOne} | P1: {millisecondsPlayerTwo}");
            }

            isPlayerOne = !isPlayerOne;
            Console.ReadKey(true);
        }
        return;
    }
}