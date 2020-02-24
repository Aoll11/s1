using s1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s1.ViewModels
{
    public class JewelryListViewModel
    {
        public IEnumerable<Jewelry> AllJewelries { get; set; }

        public string jewelryCategory { get; set; }
    }
}
