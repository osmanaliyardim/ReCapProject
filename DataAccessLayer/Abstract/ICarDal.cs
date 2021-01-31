using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int Id);
        Car GetById(int Id);

    }
}
