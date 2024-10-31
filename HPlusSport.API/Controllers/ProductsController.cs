using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : ControllerBase{
        [HttpGet]
        public string GetProducts(){
            return "OK";
        }
    }
}