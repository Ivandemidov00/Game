using System;
using MediatR;

namespace Application.Games.Command.DeleteGame
{
    public class DeleteGameCommand:IRequest
    {
        public  Int32 Id { get; set; }
    }
}