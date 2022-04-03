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
            _brandDal.Add(brand);
            return new SuccessResult("Brand added");
        }

        IResult IBrandService.Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Brand deleted");
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Brands listed");
        }

        IDataResult<Brand> IBrandService.GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(br => br.BrandId == brandId));
        }

        IResult IBrandService.Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Brand updated");
        }
    }
}
