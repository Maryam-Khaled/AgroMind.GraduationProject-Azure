namespace AgroMind.GP.APIs.DTOs.IdentityDtos
{
	public class UserDTO //Data Transfer Object 'to transfer Data fROM Back To frond and Otherwise'
	{



		public required string email { get; set; }

		public required string token { get; set; }

		public required string role { get; set; }

	}
}
