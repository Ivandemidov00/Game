using System;
using System.Collections.Generic;

namespace Domain
{
    public class Game
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Studio { get; set; }
        
        public List<GameCategories> IdGameCategoriesList { get; set; }
    }
}