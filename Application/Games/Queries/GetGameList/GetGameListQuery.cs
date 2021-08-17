using System;
using MediatR;

namespace Application.Games.Queries.GetGameList
{
    public class GetGameListQuery:IRequest<GameListVm>
    {
        public Int32 id { get; set; }
    }
}