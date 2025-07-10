using System.ComponentModel.DataAnnotations;
namespace AgroMind.GP.APIs.DTOs.IdentityDtos
{ 
	public class LoginDto
	{
		[Required]
		[EmailAddress]
	   public required string email { get; set; }

		[Required]
	   public required string password { get; set; }
	}
}
