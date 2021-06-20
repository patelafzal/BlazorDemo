using Microsoft.AspNetCore.Identity;
namespace BlazorPOC.Domain.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ApplicationRole : IdentityRole<int>
    {

    }
}
