namespace AgroMind.GP.Core.Entities
{
	public class Email
	{
		public int id { get; set; }
	   public required string To { get; set; }


	   public required string Body { get; set; }


	   public required string Subject { get; set; }
	}
}
