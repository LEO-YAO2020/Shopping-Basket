using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using ShopBasket.Models;

namespace ShopBasket.ViewModel
{
    public class CategoryIndexViewModel
    {
        public IPagedList<Category> Categories { get; set; }
    }
}