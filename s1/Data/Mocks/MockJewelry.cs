using s1.Data.Interfaces;
using s1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s1.Data.Mocks
{
    public class MockJewelry : IAllJewelry{

        private readonly IJewelryCategory _jewelryCategories = new MockCategory();
        public IEnumerable<Jewelry> Jewelries {

            get {
                return new List<Jewelry>
                {
                    new Jewelry{ name = "ring Juli", shotDesc = "fine Silver with red gem", longDesc = "It's so good, buty, and athers, red jem", img = "", price = 97, isFavourite = true, available = 17, Category = _jewelryCategories.AllCategories.First()},

                    new Jewelry{ name = "ring Lera", shotDesc = "fine Silver with blue gem", longDesc = "It's so good, buty, and athers, blue jem", img = "", price = 115, isFavourite = false, available = 3, Category = _jewelryCategories.AllCategories.First()},

                    new Jewelry{ name = "cross 1", shotDesc = "smol cross", longDesc = "It's so good, buty, and athers, but small", img = "", price = 8, isFavourite = true, available = 5, Category = _jewelryCategories.AllCategories.ElementAt(1)},

                    new Jewelry{ name = "briliant", shotDesc = "so shany", longDesc = "I like it", img = "", price = 10000, isFavourite = true, available = 7, Category = _jewelryCategories.AllCategories.Last()},

                    new Jewelry{ name = "big briliant", shotDesc = "so shany and axpencive", longDesc = "I like it very mach", img = "", price = 64000, isFavourite = false, available = 3, Category = _jewelryCategories.AllCategories.Last()}

                };
            
            } 
                
        }
        public IEnumerable<Jewelry> GetFavouritesJewelries { get; set; }

        public Jewelry GetObjJewelry(int jewelryId)
        {
            throw new NotImplementedException();
        }
    }
}
