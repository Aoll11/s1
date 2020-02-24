using Microsoft.AspNetCore.Mvc;
using s1.Data.Interfaces;
using s1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace s1.Controllers
{
    public class JewelryController: Controller
    {
        private readonly IAllJewelry _allJewelry; //благодаря прописанному в sturtup.cs мы обращаемся не только к интерфейсу, но и к классу, реализующиму данный интерфейс.
        private readonly IJewelryCategory _jewelryCategory;

        public JewelryController(IAllJewelry allJewelry, IJewelryCategory jewelryCategory)
        {
            _allJewelry = allJewelry;
            _jewelryCategory = jewelryCategory;
        }
        public ViewResult List()
        {
            JewelryListViewModel obj = new JewelryListViewModel();
            obj.AllJewelries = _allJewelry.Jewelries;
            obj.jewelryCategory = "some jem";

            return View(obj);
        }
    }
}
