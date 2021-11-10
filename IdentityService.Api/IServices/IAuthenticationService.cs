using System;
using IdentityService.Api.Domain;
using IdentityService.Api.DTOs;
using IdentityService.Api.Jwt;

namespace IdentityService.Api.IServices
{
    public interface IAuthenticationService
    {
        AuthenticationResponse Authenticate(AuthenticationRequest authenticationRequest);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly JwtGenerator _jwtGenerator;

        public AuthenticationService(JwtGenerator jwtGenerator)
        {
            _jwtGenerator = jwtGenerator;
        }

        public AuthenticationResponse Authenticate(AuthenticationRequest authenticationRequest)
        {
            var user = new User() { Id = new Guid().ToString() };
            var res = new AuthenticationResponse
            {
                Token = _jwtGenerator.Generate(user)
            };
            return res;
        }
    }
}