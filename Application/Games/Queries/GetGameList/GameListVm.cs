using System.Collections.Generic;

namespace Application.Games.Queries.GetGameList
{
    public class GameListVm
    {
        public IList<GameLookupDto> Games { get; set; }
    }
}