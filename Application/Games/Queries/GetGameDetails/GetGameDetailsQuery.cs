using System;
using MediatR;

namespace Application.Games.Queries.GetGameDetails
{
    public class GetGameDetailsQuery:IRequest<GameDetailsVM>
    {
        public Int32 id { get; set; }
    }
}