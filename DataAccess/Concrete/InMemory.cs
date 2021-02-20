using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : IProductDal
    {
        List<Car> _car;

        public InMemory(List<Car> car)
        {
            _car = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 5, ModelYear = 1999, DailyPrice = 15, Description="sdf"},
                new Car { Id = 2, BrandId = 1, ColorId = 4, ModelYear = 1888, DailyPrice = 3,  Description="dsf" },
                new Car { Id = 3, BrandId = 2, ColorId = 3, ModelYear = 1909, DailyPrice = 2,  Description="vgfvg" },
                new Car { Id = 4, BrandId = 2, ColorId = 2, ModelYear = 0909, DailyPrice = 65, Description="fggf" },
                new Car { Id = 5, BrandId = 2, ColorId = 1, ModelYear = 3332, DailyPrice = 1,  Description="rgtrg" }


            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p=>p.Id==Id).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}



       