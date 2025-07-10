namespace AgroMind.GP.APIs.DTOs.IdentityDtos
{
	public class ResetPasswordDTO
	{



		public required string Email { get; set; } // Must be non-null
		public required string Token { get; set; } // The reset token

		public required string NewPassword { get; set; } // The new password

		public required string ConfirmPassword { get; set; } // Confirmation for the new password


	}
}
