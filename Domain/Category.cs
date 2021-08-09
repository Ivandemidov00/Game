using System;
using System.Collections.Generic;

namespace Domain
{
    public class Category
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public List<GameCategories> IdCategoriesList { get; set; }
    }
}