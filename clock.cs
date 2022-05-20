using System.Threading;
using System;

public class ChessClock
{
    private static int millisecondsPlayerOne;
    private static int millisecondsPlayerTwo;

    public ChessClock(bool playerOneStarts=true, int minutes=10) {
        int millisecondsPerPlayer = minutes * 60 * 1000;

        millisecondsPlayerOne = millisecondsPerPlayer;
        millisecondsPlayerTwo = millisecondsPerPlayer;
    } 
    public IEnumerable<Gamestate> gameLoop()
    {   
        bool isPlayerOne = true;
        // create the initial gamestate
        Gamestate gamestate = new Gamestate(millisecondsPlayerOne, millisecondsPlayerTwo, isPlayerOne);

        while (!gamestateIsFinished(gamestate))
        {

            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(100);

                if (isPlayerOne)
                {
                    millisecondsPlayerOne -= 100;
                }
                else
                {
                    millisecondsPlayerTwo -= 100;

                }

                gamestate = new Gamestate(millisecondsPlayerOne, millisecondsPlayerTwo, isPlayerOne);
                Console.WriteLine(gamestate);
                yield return gamestate;
            }
            
            // swap the current player
            isPlayerOne = !isPlayerOne;
            Console.ReadKey(true);
        }
    }

    // Return true if a gamestate meets the exit conditions.
    private bool gamestateIsFinished(Gamestate gamestate)
    {
        if (gamestate.p1milliseconds <= 0 || gamestate.p2milliseconds <= 0)
        {
            return true;
        }
        return false;
    }
}