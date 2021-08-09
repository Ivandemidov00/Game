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
        
        public async Task<int> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var game = new Game
            {
                Id = request.Id,
                Name = request.Name,
                Studio = request.Studio
            };

            await _dbContext.games.AddAsync(game,cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return game.Id;
        }
    }
}