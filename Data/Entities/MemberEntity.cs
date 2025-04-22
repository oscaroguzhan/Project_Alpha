
using Microsoft.AspNetCore.Identity;
namespace Data.Entities;

public class MemberEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string? FirstName { get; set; }

    [ProtectedPersonalData]
    public string? LastName { get; set; }

    [ProtectedPersonalData]
    public string? JobTitle { get; set; } 

// One to One relationship with Address
    public virtual MemberAddressEntity? Address { get; set; }
    
   
}

