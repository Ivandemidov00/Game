using System;
using MediatR;

namespace Application.Games.Command.CreateGame
{
    public class CreateGameCommand:IRequest<Guid>
    {
        public Guid Id;
        public String Name;
        public String Studio;
    }
}