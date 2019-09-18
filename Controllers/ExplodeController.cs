using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;


namespace Explode
{

  [Route("api/[controller]")]
  [ApiController]
  public class Controller : ControllerBase
  {

    [HttpGet("{name}")]
    public ActionResult<string> WelcomeMessage(string name)
    {
      return "Hello,  " + name;
    }

    [HttpGet("sum/{x}/{y}")]
    public ActionResult<int> Sum(int x, int y)
    {
      if (x > 10)
      {
        return x * y;
      }
      return x + y;
    }

    [HttpPost("subtract/{x}/{y}")]
    public ActionResult<string> DoThePostThing(string x, string y)
    {

      return (int.Parse(x) - int.Parse(y)).ToString();
    }

    public static string Explode(string s)
    {
      var x = String.Join("", s.Select((letter, i) => String.Join("", Enumerable.Repeat(letter, (int)Char.GetNumericValue(letter)))));

      return x;

    }
  }
}
