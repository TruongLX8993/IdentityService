using System.Threading.Tasks;
using IdentityService.Api.DTOs;
using IdentityService.Api.IServices;
using Microsoft.AspNetCore.Mvc;

namespace IdentityService.Api.Controller
{
    [ApiController]
    [Route("api/account/")]
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [Route("authenticate")]
        [HttpPost]
        public IActionResult Authenticate(AuthenticationRequest request)
        {
            var authenticationResponse = _authenticationService.Authenticate(request);
            return Ok(authenticationResponse);
        }
    }
}