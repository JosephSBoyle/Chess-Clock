using static ChessClock;
using Xunit;
namespace ChessClockTests;
public class UnitTest1
{
    [Fact]
    public void TestTiming()
    {
        ChessClock clock = new ChessClock();
        int ticks = 10;

        DateTime start = DateTime.Now;
        foreach (Gamestate gamestate in clock.gameLoop().Take(ticks))
        {
        }
        DateTime end = DateTime.Now;

        double diffInSeconds = (end - start).TotalSeconds;
        Console.WriteLine(diffInSeconds);

        Assert.InRange(diffInSeconds, 0.98, 1.02);
    }
}