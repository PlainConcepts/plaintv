using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PlainTV.ConfigurationAspNet.Model;

namespace PlainTV.ConfigurationAspNet.Controllers
{
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly Data data;

        public ConfigurationController(IOptionsSnapshot<Data> options)
        {
            this.data = options.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(data.ConnectionString);
        }
    }
}
