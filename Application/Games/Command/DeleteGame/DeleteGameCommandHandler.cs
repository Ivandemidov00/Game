using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Application.Comman.Exceptions;
using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Games.Command.DeleteGame
{
    public class DeleteGameCommandHandler:IRequestHandler<DeleteGameCommand>
    {
        private readonly IGameDbContext _IgameDbContext;

        public DeleteGameCommandHandler(IGameDbContext IgameDbContext)
        {
            _IgameDbContext = IgameDbContext;
        }

        public async Task<Unit> Handle(DeleteGameCommand request, CancellationToken cancellationToken)
        {
            var entity = await _IgameDbContext.games.FindAsync(new object[] { request.Id }, cancellationToken);
            if (entity == null || entity.id != request.Id)
            {
                throw new NotFoundException(nameof(Game), request.Id);
            }

            _IgameDbContext.games.Remove(entity);
            await _IgameDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}