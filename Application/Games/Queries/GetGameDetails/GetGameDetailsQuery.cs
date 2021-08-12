using System;
using MediatR;

namespace Application.Games.Queries.GetGameDetails
{
    public class GetGameDetailsQuery:IRequest<GameDetailsVM>
    {
        public Guid Id { get; set; }
    }
}