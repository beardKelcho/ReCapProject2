using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                // 1 siyah 2 beyaz 3 kırmızı 4 lacivert 5 sarı
                new Car{CarId = 1, BrandId = 1,ColorId=3, ModelYear=2022,DailyPrice=350000,Description="Ssangyon ActyonSports"},
                new Car{CarId = 2, BrandId = 2,ColorId=1, ModelYear=2022,DailyPrice=600000,Description="Ford Ranger"},
                new Car{CarId = 3, BrandId = 3,ColorId=1, ModelYear=2022,DailyPrice=500000,Description="Mitsbushi L200"},
                new Car{CarId = 4, BrandId = 4,ColorId=2, ModelYear=2022,DailyPrice=1000000,Description="Tesla Truck"},
                new Car{CarId = 5, BrandId = 5,ColorId=3, ModelYear=2022,DailyPrice=750000,Description="Volkswagen Amorok"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
            
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToUpdate == null)
            {
                Console.WriteLine("Güncellemek istediğiniz araba bulunamadı");   
            }
            else
            {
                carToUpdate.BrandId=car.BrandId;
                carToUpdate.ColorId=car.ColorId;
                carToUpdate.ModelYear=car.ModelYear;
                carToUpdate.DailyPrice=car.DailyPrice;
                carToUpdate.Description=car.Description;

            }
            
        }
    }
}
