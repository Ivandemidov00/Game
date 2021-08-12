using System;
using MediatR;

namespace Application.Games.Queries.GetGameList
{
    public class GetGameListQuery:IRequest<GameListVm>
    {
        public Guid Id { get; set; }
    }
}