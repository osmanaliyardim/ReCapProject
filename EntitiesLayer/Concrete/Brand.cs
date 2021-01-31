using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Brand:IEntities
    {
        public int BrandId { get; set; }
        public int BrandName { get; set; }
    }
}
