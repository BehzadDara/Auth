using Auth.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class BaseController : Controller
    {
        public static User CurrentUser { get; set; } = new();
    }
}
