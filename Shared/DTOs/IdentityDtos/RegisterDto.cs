using System.ComponentModel.DataAnnotations;

namespace AgroMind.GP.APIs.DTOs.IdentityDtos
{
	public class RegisterDTO
	{









		[Required]
		public required string fname { get; set; } // Changed from Fname for consistency

		[Required]
		public required string lname { get; set; } // Changed from Lname for consistency

		[Required]
		public required string userName { get; set; }

		[Required]
		[EmailAddress]
		public required string email { get; set; }

		[Required]
		[Phone]
		public required string phoneNumber { get; set; }

		[Required]
		public required string gender { get; set; }

		[Required]
		public required int age { get; set; }
		public required string role { get; set; } // Changed from role

		public required string password { get; set; }

		[Compare("password")]
		public required string confirmPassword { get; set; }

		//[Required]
		//[RegularExpression(
		//   @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()_+~`|}{[\]:;?,.<>]).{8,}$",
		//   ErrorMessage = "Password must contain at least 1 Uppercase, 1 Lowercase, 1 Digit, 1 Special Character, and be at least 8 characters long.")]



		//[Required(ErrorMessage = "Confirm Password Is Required")]
		//[DataType(DataType.Password)]
		//[Compare("password", ErrorMessage = "Passwords do not match.")]


	}

}

