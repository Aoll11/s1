using s1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Отвечает за получение категорий 
namespace s1.Data.Interfaces
{
    public interface IJewelryCategory
    {
        IEnumerable<Category> AllCategories { get; }
        //List<Category> AllCategories { get; }
    }
}
