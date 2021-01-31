using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car { CarId = 1, BrandId = 1, ColorId = 3, DailyPrice = 33.0000m, Description = "Toyota Corolla 2008", ModelYear = 2008 },
                new Car { CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 133.0000m, Description = "Honda ACZ 2011", ModelYear = 2011 },
                new Car { CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 333.0000m, Description = "Volkswagen Passat 2015", ModelYear = 2015 },
                new Car { CarId = 4, BrandId = 3, ColorId = 2, DailyPrice = 9.000m, Description = "Seat Ibiza 01", ModelYear = 2001 },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int Id)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.CarId == Id);

            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.CarId == car.CarId);

            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(x => x.CarId == Id);
        }
    }
}
