using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_webapi.Models;

namespace dotnet_webapi.Data
{
	public class SqlApiRepo : IApiRepo
	{
		private readonly ApiContext _context;

		public SqlApiRepo(ApiContext context)
		{
			_context = context;
		}

		public void CreateCommand(Command cmd)
		{
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			_context.Commands.Add(cmd);
		}

		public IEnumerable<Command> GetAllCommands()
		{
			return _context.Commands.ToList();
		}

		public Command GetCommandById(String id)
		{
			return _context.Commands.FirstOrDefault(p => p.Id == new Guid(id));
		}

		public bool SaveChanges()
		{
			return (_context.SaveChanges() >= 0);
		}
	}
}