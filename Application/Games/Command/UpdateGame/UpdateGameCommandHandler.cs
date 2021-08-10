using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Comman.Exceptions;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Games.Command.UpdateGame
{
    public class UpdateGameCommandHandler:IRequest<UpdateGameCommand>
    {
        private readonly IGameDbContext _gameDbContext;

        public UpdateGameCommandHandler(IGameDbContext iGameDbContext)
        {
            _gameDbContext = iGameDbContext;
        }

        public async Task<Unit> Handle(UpdateGameCommand request, CancellationToken cancellationToken)
        {
            var entity =
                await _gameDbContext.games.FirstOrDefaultAsync(note =>
                    note.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Game), request.Id);
            }

            entity.Name = request.Name;
            entity.Studio = request.Studio;
            
            await _gameDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}