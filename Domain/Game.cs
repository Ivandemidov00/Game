using System;
using System.Collections.Generic;

namespace Domain
{
    public class Game
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Studio { get; set; }
        
        public List<GameCategories> IdGameCategoriesList { get; set; }
    }
}