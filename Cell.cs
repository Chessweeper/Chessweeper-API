namespace Chessweeper_API;

public class Cell
{
    public object Value { get; set; } // string or int
    public int AttackedValue { get; set; }
    public object Known { get; set; } // boolean or string
}
