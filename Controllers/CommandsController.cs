using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_webapi.Models;
using dotnet_webapi.Data;
using AutoMapper;
using dotnet_webapi.Dtos;
using System;

namespace dotnet_webapi.Controllers
{
	[Route("api/commands")]
	[ApiController]
	public class CommandsController : ControllerBase
	{
		private readonly IApiRepo _repository;
		private readonly IMapper _mapper;

		public CommandsController(IApiRepo repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
		{
			var commandItems = _repository.GetAllCommands();
			return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
		}

		[HttpGet("{id}", Name = "GetCommandById")]
		public ActionResult<CommandReadDto> GetCommandById(String id)
		{
			var commandItem = _repository.GetCommandById(id);

			if (commandItem != null)
			{
				return Ok(_mapper.Map<CommandReadDto>(commandItem));
			}

			return NotFound();
		}

		[HttpPost]
		public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
		{
			var commandModel = _mapper.Map<Command>(commandCreateDto);
			_repository.CreateCommand(commandModel);
			_repository.SaveChanges();

			var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

			return CreatedAtRoute(nameof(GetCommandById), new { Id = commandReadDto.Id }, commandReadDto);
		}
	}
}