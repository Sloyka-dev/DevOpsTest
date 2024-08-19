using DevOpsTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsTest.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    
    private readonly ILogger<HomeController> _logger;
    private readonly IDataService _dataService;

    public HomeController(ILogger<HomeController> logger, IDataService dataService)
    {
        _logger = logger;
        _dataService = dataService;
    }

    [HttpGet]
    public IActionResult SetText([FromQuery]string text)
    {

        var id = _dataService.SetText(text);
        return Ok($"Id of message: {id.ToString()}");

    }

    [HttpGet("{id}")]
    public IActionResult GetText([FromRoute]int id)
    {

        var text = _dataService.GetText(id);

        if(text is null) return NotFound("Message not found on server!");
        return Ok($"Message is {text}");

    }

}
