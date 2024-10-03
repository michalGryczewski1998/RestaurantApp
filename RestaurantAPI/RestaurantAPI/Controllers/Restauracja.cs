using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Mode.PrzyjmowaneDane.RestauracjaInfo;

namespace RestaurantAPI.Controllers
{
    [Route("api/restauracja")]
    [ApiController]
    [AllowAnonymous]
    public class Restauracja : ControllerBase
    {
        [HttpPost("dodajRestauracje")]
        public ActionResult DodajRestauracje([FromBody] RestauracjaModel data)
        {
            if (data == null)
            {
                return BadRequest();
            }

            RestauracjaModel restauracja = data;
            return Ok();
        }
    }
}
