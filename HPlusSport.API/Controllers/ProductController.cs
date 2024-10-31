using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controllers]")]
    [ApiController]
    public class ProductsContoller : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "OK";
        }
    }
}