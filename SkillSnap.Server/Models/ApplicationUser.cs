using Microsoft.AspNetCore.Identity;

namespace SkillSnap.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Bio { get; set; }
    }
}