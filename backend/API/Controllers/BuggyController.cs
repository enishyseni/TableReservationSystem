using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController

    {

        [HttpGet("Not-Found")]

        public ActionResult GetNotFound()
        {
            return NotFound();
            
        }

        [HttpGet("Bad-Request")]

        public ActionResult GetBadRequest()

        {
            return BadRequest("This is a bad request");
        }

        [HttpGet("Server - Error")]
        public ActionResult GetUnathorized()
        {
            return Unauthorized();
            
        }


        
        

        
    }
}