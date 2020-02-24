using s1.Data.Interfaces;
using s1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s1.Data.Mocks
{
    public class MockCategory : IJewelryCategory
    {
        //public List<Category> AllCategories {
        public IEnumerable<Category> AllCategories { 
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Колечки", description = "красивые колечки"},
                    new Category { categoryName = "Crosses", description = "ortodox crosses"},
                    new Category { categoryName = "Jemstone", description = "beauty jem"}
                    
                };
            }
        }
    }
}
