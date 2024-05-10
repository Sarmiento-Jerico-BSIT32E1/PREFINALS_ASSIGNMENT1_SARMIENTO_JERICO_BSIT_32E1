using Microsoft.AspNetCore.Mvc;
using System;

namespace ProtectedApi
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly string _owner = "Jerico J Q. Sarmiento";
        private readonly Random _random = new Random();
        private readonly string[] _thingsAboutOwner = new[]
        {
            "Studying at Lyceum of Alabang",
            "Course:BSIT",
            "Age:22",
            "Supreme Student Council BSIT Representative / Director for Internal Activities",

        };

        [HttpGet("about/me")]
        public IActionResult AboutMe()
        {
            var thing = _thingsAboutOwner[_random.Next(_thingsAboutOwner.Length)];
            return Ok(thing);
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(_owner);
        }

        [HttpPost("about")]
        public IActionResult About([FromBody] NameModel model)
        {
            return Ok($"Hi {model.Name} from {_owner}");
        }
    }

    public class NameModel
    {
        public string? Name { get; set; }
    }
}