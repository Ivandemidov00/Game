using System;
using MediatR;

namespace Application.Games.Command.UpdateGame
{
    public class UpdateGameCommand:IRequest
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Studio { get; set; }
    }
}