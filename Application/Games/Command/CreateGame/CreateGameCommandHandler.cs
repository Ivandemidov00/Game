using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Games.Command.CreateGame
{
    public class CreateGameCommandHandler:IRequestHandler<CreateGameCommand,Int32>
    {
        private readonly IGameDbContext _dbContext;

        public CreateGameCommandHandler(IGameDbContext dbContext) => _dbContext = dbContext;
        
        public async Task<Int32> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var game = new Game
            {
                id = request.Id,
                name = request.Name,
                studio = request.Studio
            };

            await _dbContext.games.AddAsync(game,cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return game.id;
        }
    }
}