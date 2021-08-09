using System;
using MediatR;

namespace Application.Games.Command.CreateGame
{
    public class CreateGameCommand:IRequest<Int32>
    {
        public Int32 Id;
        public String Name;
        public String Studio;
    }
}