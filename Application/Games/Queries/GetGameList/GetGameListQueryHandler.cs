using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Games.Queries.GetGameList
{
    public class GetGameListQueryHandler:IRequestHandler<GetGameListQuery,GameListVm>
    {
        private readonly IGameDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetGameListQueryHandler(IGameDbContext dbContext,
            IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<GameListVm> Handle(GetGameListQuery request,
            CancellationToken cancellationToken)
        {
            var gamesQuery = await _dbContext.games
               // .Where(game => game.id == request.id)
                .ProjectTo<GameLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new GameListVm { Game = gamesQuery };
        }
    }
}