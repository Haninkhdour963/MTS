using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    // Add custom properties here if needed
    public string? FullName { get; set; } // Example custom property
}
