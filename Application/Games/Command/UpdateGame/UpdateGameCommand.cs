using System;

namespace Application.Games.Command.UpdateGame
{
    public class UpdateGameCommand
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Studio { get; set; }
    }
}