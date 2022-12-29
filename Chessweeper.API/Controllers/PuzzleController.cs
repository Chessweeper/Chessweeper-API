using Microsoft.AspNetCore.Mvc;

namespace Chessweeper_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PuzzleController : ControllerBase
{

    private readonly ILogger<PuzzleController> _logger;

    public PuzzleController(ILogger<PuzzleController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IEnumerable<Cell> Get(SetupData setupData)
    {
        return Algs.GeneratePuzzleBoard(setupData);
    }
}