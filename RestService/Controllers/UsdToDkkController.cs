using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestService.Models;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsdToDkkController : ControllerBase
    {
        [HttpGet]
        public Amount Get(double value)
        {
            Amount result = new();
            result.Value = value * 6.53;
            result.Currency = "DKK";
            return result;
        }
    }
}
