using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_webapi.Models
{
	public class Command
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string HowTo { get; set; }

		[Required]
		public string Line { get; set; }

		[Required]
		public string Platform { get; set; }
	}
}