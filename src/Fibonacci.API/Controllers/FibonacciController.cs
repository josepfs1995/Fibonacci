using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
{

    private readonly ILogger<FibonacciController> _logger;

    public FibonacciController(ILogger<FibonacciController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{index}")]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Get(int index)
    {
        return Ok(Fibonnaci(index));
    }
    private int Fibonnaci(int index)
    {
        int number1 = 0, number2 = 1, result = 0;

        if (index == 0) return number1;
        if (index == 1) return number2;
        for (int i = 2; i <= index; ++i)
        {
            result = number1 + number2;
            number1 = number2;
            number2 = result;
        }
        return result;
    }
}
