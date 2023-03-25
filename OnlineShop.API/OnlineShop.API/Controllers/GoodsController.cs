using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.API.Controllers
{
    [Route("goods")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string request)
        {
            return Ok();
        }
    }
}
