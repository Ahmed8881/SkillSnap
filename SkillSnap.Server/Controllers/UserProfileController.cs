using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkillSnap.Shared.Models;

namespace SkillSnap.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<UserProfile> Get(string id)
        {
            // Example: fetch user profile from DB
            return new UserProfile { Id = id, Name = "Jane Doe", Bio = "Full Stack Dev", Skills = new[] { "C#", "Blazor" } };
        }
    }
}