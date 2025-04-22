
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entities;

public class MemberAddressEntity 
{
    [Key, ForeignKey("Member")]
    public string UserId { get; set; } = string.Empty;
    public string StreetName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;

    public virtual MemberEntity Member { get; set; } = null!;
} 