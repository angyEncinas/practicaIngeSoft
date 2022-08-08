using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practiceTwo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;

         }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUser(User user)
        {
            return Ok(_userManager.PostUser(user));
        }
        [HttpDelete]
        public IActionResult DeleteUser(User user)
        
        {
            if (_userManager.DeleteUser(user) == null)
            {
                return NotFound("The user Id does not exist");
            }
            return Ok(_userManager.DeleteUser(user));
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            if (_userManager.PutUser(user) == null)
            {
                return NotFound("The user Id does not exist");
            }
            return Ok(_userManager.PutUser(user));
        }
    }
}
