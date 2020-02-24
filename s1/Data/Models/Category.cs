using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Категории товаров.

namespace s1.Data.Models
{
    public class Category
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string description { set; get; }

        //public int jewerlyId { set; get; } //отличие от примера

        public List<Jewelry> jewerly{ set; get; } //Какие товары входят в эту категорию


    }
}
