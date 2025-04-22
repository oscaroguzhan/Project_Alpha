
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Business.Models;

public class EditMemberForm
{
    public int MemberId { get; set; }
    
    [Display(Name = "Member Image", Prompt = "Upload a image")]
    [DataType(DataType.Upload)]
    public IFormFile? MemberImage { get; set; }

    [Display(Name = "Member Name", Prompt = "Enter Member name")]
    [StringLength(100, ErrorMessage = "Member name cannot exceed 100 characters.")]
    [MinLength(2, ErrorMessage = "Member name must be at least 2 characters long.")]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Required.")]
    public string MemberName { get; set; } = null!;

    [Display(Name = "Email", Prompt = "Enter email address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Required.")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
    public string Email { get; set; } = null!;

    [Display(Name = "Location", Prompt = "Enter location")]
    public string? Location { get; set; } 

    [Display(Name = "Phone Number", Prompt = "Enter phone number")]
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Invalid phone number format.")]
    public string? Phone { get; set; } 
}
