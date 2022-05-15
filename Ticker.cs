using System.Collections;

class Ticker
{
    public static IEnumerable<int> tick()
    {
        int tick = 0;
        while (true)
        {
            tick++;
            Thread.Sleep(100);
            yield return tick;
        }
    }
}