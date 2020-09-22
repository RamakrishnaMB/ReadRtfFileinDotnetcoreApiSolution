using Microsoft.AspNetCore.Mvc;
using RTFProcessor;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadRtfFileinDotnetcoreApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReadRTFController : ControllerBase
    {
        // GET: api/<ReadRTFController>
        [HttpGet]
        public IActionResult Get()
        {
            FileProcessor fileProcessor = new FileProcessor();
            var output = fileProcessor.ReadAndReplaceRTFFile();

            return StatusCode((int)HttpStatusCode.OK, output);
        }
    }
}