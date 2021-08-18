using System;
using MediatR;

namespace Application.Games.Command.DeleteGame
{
    public class DeleteGameCommand:IRequest
    {
        public  Guid Id { get; set; }
    }
}