using dotnet_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi.Data
{
	public class ApiContext : DbContext
	{
		public ApiContext(DbContextOptions<ApiContext> opt) : base(opt)
		{

		}

		public DbSet<Command> Commands { get; set; }

	}
}