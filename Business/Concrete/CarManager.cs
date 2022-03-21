using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("Araç Eklendi");
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Araç silindi");
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("-----Bütün Liste Gelir----");
            return _carDal.GetAll();
        }

        //public List<Car> GetByeId(int id)
        //{
        //    Console.WriteLine("id ye göre gelir");
        //    return _carDal.GetById(id);
           
        //}

        public List<Car> GetById(int id)
        {
            Console.WriteLine("id ye göre gelir");
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            Console.WriteLine("Araç güncellendi");
            _carDal.Update(car);
        }
    }
}
