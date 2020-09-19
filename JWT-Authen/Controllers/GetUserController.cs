using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JWT_Authen.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Authen.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class GetUserController : ControllerBase
    {
        [HttpGet]
        [Route("get")]
        [Authorize]
        public ActionResult<string> Get()
        {
            var currentUser = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return currentUser;
        }
    }
}
