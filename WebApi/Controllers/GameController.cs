using System;
using System.Data.Common;
using System.Threading.Tasks;
using Application.Games.Command.CreateGame;
using Application.Games.Command.DeleteGame;
using Application.Games.Command.UpdateGame;
using Application.Games.Queries.GetGameDetails;
using Application.Games.Queries.GetGameList;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class GameController : BaseController
    {
        private readonly IMapper _mapper;

        public GameController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<GameListVm>> GetAll()
        {
            var query = new GetGameListQuery
            {
                id = UserId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameListVm>> Get(Guid id)
        {
           var query = new GetGameDetailsQuery
            {
                id = id
            };
           
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateGameDto createNoteDto)
        {
            var command = _mapper.Map<CreateGameCommand>(createNoteDto);
            command.Id = UserId;
            var noteId = await Mediator.Send(command);
            return Ok(noteId);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateGameDto updateNoteDto)
        {
            var command = _mapper.Map<UpdateGameCommand>(updateNoteDto);
            command.Id = UserId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
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