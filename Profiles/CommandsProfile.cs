using AutoMapper;
using dotnet_webapi.Dtos;
using dotnet_webapi.Models;

namespace dotnet_webapi.Profiles
{
	public class CommandsProfile : Profile
	{
		public CommandsProfile()
		{
			CreateMap<Command, CommandReadDto>();
			CreateMap<CommandCreateDto, Command>();
		}
	}
}