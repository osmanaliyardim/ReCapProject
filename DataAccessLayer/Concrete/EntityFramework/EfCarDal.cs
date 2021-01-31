using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            List<Car> _cars = new List<Car> { 
                new Car{CarId=100,BrandId=3,ColorId=1,DailyPrice=999.999m,Description="Ef Deneme Car",ModelYear=1990},
                new Car{CarId=101,BrandId=2,ColorId=2,DailyPrice=9.222m,Description="2Ef Deneme Car2",ModelYear=1990},
            };

            return _cars;
        }

        public Car GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
