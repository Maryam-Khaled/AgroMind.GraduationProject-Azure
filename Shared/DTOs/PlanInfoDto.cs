using AgroMind.GP.APIs.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
	public class PlanInfoDto
	{
	   public required CropDto Crop { get; set; }
	   public required string CreatorEmail { get; set; }
	   public required string CreatorRole { get; set; }
	   public required string PlanType { get; set; }
	}

}

