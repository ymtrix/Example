using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Services
    {
        //[ServiceContract]
        //public interface IXmlPayloadService
        //{
        //    [OperationContract]
        //    int GetStatusCodeOfXMLPayload(XmlElement xmlElement);
        //}

        //public class XmlPayloadService : IXmlPayloadService
        //{

        //    public int GetStatusCodeOfXMLPayload(XmlElement xmlElement)
        //    {
        //        //Calling ABM.Core library method and passing xml payload as xmlElement
        //        return XmlParser.ParseWebApiXML(xmlElement);
        //    }
        //}


        //public class ProductsController : ApiController
        //{
        //   [httpPost]
        //    public IHttpActionResult GetProduct(int id)
        //    {
        //        var product = products.FirstOrDefault((p) => p.Id == id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(product);
        //    }
        //}

        //[ApiController]
        //[Route("[controller]")]
        //public class WeatherForecastController : ControllerBase
        //{
        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //    private readonly ILogger<WeatherForecastController> _logger;

        //    public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //    {
        //        _logger = logger;
        //    }

        //    [HttpGet]
        //    public IEnumerable<WeatherForecast> Get()
        //    {
        //        var rng = new Random();
        //        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        {
        //            Date = DateTime.Now.AddDays(index),
        //            TemperatureC = rng.Next(-20, 55),
        //            Summary = Summaries[rng.Next(Summaries.Length)]
        //        })
        //        .ToArray();
        //    }
        //}
    }
}
