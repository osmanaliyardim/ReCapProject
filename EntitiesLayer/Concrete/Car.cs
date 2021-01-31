using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Car:IEntities
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
