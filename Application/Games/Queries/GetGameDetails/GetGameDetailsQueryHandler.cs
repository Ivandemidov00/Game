using System.Threading;
using System.Threading.Tasks;
using Application.Comman.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Games.Queries.GetGameDetails
{
    public class GetGameDetailsQueryHandler:IRequestHandler<GetGameDetailsQuery,GameDetailsVM>
    {
       
        private readonly IGameDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetGameDetailsQueryHandler(IGameDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<GameDetailsVM> Handle(GetGameDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.games
                .FirstOrDefaultAsync(note =>
                    note.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Game), request.Id);
            }

            return _mapper.Map<GameDetailsVM>(entity);
        }
        
    }
}