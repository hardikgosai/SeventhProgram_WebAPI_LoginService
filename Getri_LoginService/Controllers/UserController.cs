using Getri_LoginService.Models;
using Getri_LoginService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_LoginService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository iUserRepository;

        public UserController(IUserRepository _iUserRepository)
        {
            iUserRepository = _iUserRepository;
        }

        [HttpPost("LoginUser")]
        //[FromBody] attribute is used to specify that the value should be read from the request body.
        public IActionResult LoginValidate([FromBody] User objUser)
        {
            var result = iUserRepository.LoginValidate(objUser.Username, objUser.Password);
                       
            return Ok(result);            
        }

        [HttpPost("RegisterUser")]
        public IActionResult CreateUser([FromBody] User objUser)
        {
            var result = iUserRepository.CreateUser(objUser);
                        
            return Ok(result);            
        }
    }
}
