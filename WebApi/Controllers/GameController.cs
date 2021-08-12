﻿using System;
using System.Data.Common;
using System.Threading.Tasks;
using Application.Games.Command.CreateGame;
using Application.Games.Command.DeleteGame;
using Application.Games.Command.UpdateGame;
using Application.Games.Queries.GetGameDetails;
using Application.Games.Queries.GetGameList;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class NoteController : BaseController
    {
        private readonly IMapper _mapper;

        public NoteController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<GameListVm>> GetAll()
        {
            var query = new GetGameListQuery
            {
                Id = IdentifierCase;
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameListVm>> Get(Int32 id)
        {
            var query = new GetGameDetailsQuery
            {
                Id = id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateGameDto createNoteDto)
        {
            var command = _mapper.Map<CreateGameCommand>(createNoteDto);
            command.Id = Id;
            var noteId = await Mediator.Send(command);
            return Ok(noteId);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateGameDto updateNoteDto)
        {
            var command = _mapper.Map<UpdateGameCommand>(updateNoteDto);
            command.Id = id;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Int32 id)
        {
            var command = new DeleteGameCommand
            {
                Id = id
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}