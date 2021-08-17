using System.Collections.Generic;

namespace Application.Games.Queries.GetGameList
{
    public class GameListVm
    {
        public IList<GameLookupDto> Game { get; set; }
    }
}