public struct Gamestate
{
    public Gamestate(int p1milliseconds, int p2milliseconds, bool isPlayerOne)
    {
        this.p1milliseconds = p1milliseconds;
        this.p2milliseconds = p2milliseconds;

        this.isPlayerOne = isPlayerOne;
    }

    public int p1milliseconds { get; }
    public int p2milliseconds { get; }
    public bool isPlayerOne { get; }


    public override string ToString() => $"P2: {p1milliseconds} | P1: {p2milliseconds} | P1's turn: {isPlayerOne}";

}