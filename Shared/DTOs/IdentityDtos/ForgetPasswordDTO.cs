using System.ComponentModel.DataAnnotations;

namespace AgroMind.GP.APIs.DTOs.IdentityDtos
{
    public class ForgetPasswordDTO
    {

        public required string Email { get; set; }
    }
}
