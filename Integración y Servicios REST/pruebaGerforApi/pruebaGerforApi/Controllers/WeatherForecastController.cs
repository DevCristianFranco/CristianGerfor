using Microsoft.AspNetCore.Mvc;

namespace pruebaGerforApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       static List<Product> products = new List<Product>();


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public List<Product> Get()
        {
           return products;
        }

        [HttpPost(Name = "SetProduct")]
        public bool Post(Product product)
        {
           products.Add(product);
            return true;
        }
    }
}
