using System;

namespace Domain
{
    public class GameCategories
    {
        public Int32 IdGame { get; set; }
        public Game Game { get; set; }
        
        public Int32 IdCategories { get; set; }
        public Category Category { get; set; }
     
    }
}