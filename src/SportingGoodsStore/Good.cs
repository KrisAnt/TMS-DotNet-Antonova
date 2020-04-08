using System;
using System.Collections.Generic;
using System.Text;

namespace SportingGoodsStore
{
    public abstract class Good
    {
        public string Description { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }

    }
}
