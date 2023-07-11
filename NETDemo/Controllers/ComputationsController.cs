using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETDemo.Services;

namespace NETDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComputationsController : ControllerBase
{
    private readonly ICalculatorService calculatorService;
    private readonly MyHttpClient httpClient;

    public ComputationsController(ICalculatorService calculatorService, MyHttpClient httpClient)
    {
        this.calculatorService = calculatorService;
        this.httpClient = httpClient;
    }

    [HttpGet("/square")]
    public async Task<IActionResult> SquareArea([FromQuery] int side)
    {
        var area = calculatorService.GetAreaOfSquare(side);
        return Ok(area);
    }

    [HttpGet("/apicall")]
    public async Task<IActionResult> GetNumberOfUsers()
    {
        var content = await httpClient.Get("https://jsonplacehosdfglder.typicode.com/commtiuyents?postId=1");
        return Ok(content);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser()
    {
        await httpClient.CreateUser("Gigel", "parola");
        return Ok();
    }
}
