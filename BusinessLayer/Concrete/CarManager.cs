using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //Buraya iş kodları yazılabilir...
            //Kimin hangi sayfaya erişim yetkisi olacağı olacağı/kontroller vs...

            return _carDal.GetAll();
        }
    }
}
