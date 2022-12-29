namespace Chessweeper_API;

public class SetupData
{
    public string Seed { get; set; }
    public Dictionary<string, int> Pieces { get; set; }
    public int Size { get; set; }
    public int Count { get; set; }
    public char Gamemode { get; set; }
    public int Difficulty { get; set; }
}
