using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        IResult IBrandService.Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        IResult IBrandService.Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Brand> IBrandService.GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        IResult IBrandService.Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
