using Auth.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Auth.Controllers
{
    public class BaseController : Controller
    {
        public User CurrentUser
        {
            get
            {
                if (HttpContext.User.Identity is ClaimsIdentity identity)
                {
                    var username = identity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
                    var user = UserConstants.Users.FirstOrDefault(x => x.Username.Equals(username));
                    if (user is not null)
                    {
                        return user;
                    }
                }
                return new();
            }
        }
    }
}
