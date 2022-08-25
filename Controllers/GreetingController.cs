using Microsoft.AspNetCore.Mvc;
using greetingservice.Models;
using System.Net;

namespace greetingservice.Controllers;

[ApiController]
[Route("/greeting")]
public class GreetingController : ControllerBase
{
    private readonly ILogger<GreetingController> _logger;

    public GreetingController(ILogger<GreetingController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetGreeting")]
    public Greeting Get(string name)
    {
        return new Greeting()
        {
            Message = String.Format("Hello {0} From Host: {1}", name, Dns.GetHostName())
        };
    }
}
