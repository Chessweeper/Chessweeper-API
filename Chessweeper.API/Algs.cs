namespace Chessweeper_API;

public class Algs
{
    // Dummy Generate Puzzle Board Algorithm
    public static IEnumerable<Cell> GeneratePuzzleBoard(SetupData setupData)
    {
        var size = setupData.Size;

        var emptyCell = new Cell()
        {
            Value = 0,
            AttackedValue = 0,
            Known = false,
        };

        var cells = Enumerable.Repeat(emptyCell, size * size).ToList();

        cells[0].Value = 'R';
        cells[1].Value = 'B';

        cells[2].Value = '2';
        cells[2].Known = true;

        return cells;
    }
}
