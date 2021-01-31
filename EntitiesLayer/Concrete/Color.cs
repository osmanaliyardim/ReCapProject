using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Color:IEntities
    {
        public int ColorId { get; set; }
        public int ColorName { get; set; }
    }
}
