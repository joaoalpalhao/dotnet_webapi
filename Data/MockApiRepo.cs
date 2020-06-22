using System;
using System.Collections.Generic;
using dotnet_webapi.Models;

namespace dotnet_webapi.Data
{
	public class MockApiRepo : IApiRepo
	{
		public void CreateCommand(Command cmd)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Command> GetAllCommands()
		{
			var commands = new List<Command>
			{
				new Command { Id = new Guid("ed5b981c-ba06-46a8-bad6-91c7d3d3590f"), HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettler & pan" },
				new Command { Id = new Guid("55ec66bb-11a5-4891-8db4-1e268ad4ce0d"), HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & chopping board" },
				new Command { Id = new Guid("e664aa75-e2dc-4690-9153-ffbdb1a91cf0"), HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettler & cup" }
			};

			return commands;
		}

		public Command GetCommandById(String id)
		{
			return new Command { Id = new Guid("ed5b981c-ba06-46a8-bad6-91c7d3d3590f"), HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettler & Pan" };
		}

		public bool SaveChanges()
		{
			throw new System.NotImplementedException();
		}
	}
}