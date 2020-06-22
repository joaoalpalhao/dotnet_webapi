using System;
using System.Collections.Generic;
using dotnet_webapi.Models;

namespace dotnet_webapi.Data
{
	public interface IApiRepo
	{
		bool SaveChanges();

		IEnumerable<Command> GetAllCommands();
		Command GetCommandById(String id);
		void CreateCommand(Command cmd);
	}
}