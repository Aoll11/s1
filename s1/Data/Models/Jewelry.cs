using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// описание товаров

namespace s1.Data.Models
{
    public class Jewelry
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shotDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; } //url где взять картинку

        public ushort price { set; get; }

        public bool isFavourite { set; get; } //то, что отображать на главной в блоке "лучшие товары"

        public int available { set; get; } //сколько единиц на складе

        public int categoryId { set; get; } //присваивает объект к категории

        public virtual Category Category { set; get; } // объект, сооответсвующей категориям


    }
}
