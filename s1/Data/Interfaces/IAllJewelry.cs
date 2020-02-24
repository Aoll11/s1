using s1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Для работы с товаром
namespace s1.Data.Interfaces
{
    public interface IAllJewelry
    {
        IEnumerable<Jewelry> Jewelries { get; }
        IEnumerable<Jewelry> GetFavouritesJewelries { get; set; }
        Jewelry GetObjJewelry(int jewelryId);
    }
}
