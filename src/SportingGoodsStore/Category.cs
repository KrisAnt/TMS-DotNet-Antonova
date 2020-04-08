using System;
using System.Collections.Generic;
using System.Text;

namespace SportingGoodsStore
{
    public abstract class Category
    {
        protected List<Good> goods = new List<Good>();
        public abstract void View();
    }

}
