using System;
using System.Collections.Generic;

namespace Domain
{
    public class Game
    {
        public Guid id { get; set; }
        public String name { get; set; }
        public String studio { get; set; }
        
        public List<GameCategories> IdGameCategoriesList { get; set; }
    }
}