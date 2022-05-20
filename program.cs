using static Renderer;

class Clock
{

    public static void Main(string[] args)
    {   
        ChessClock clock = new ChessClock();
        foreach (Gamestate gamestate in clock.gameLoop()){
            Renderer.render(gamestate);
        } 
        
    }
}