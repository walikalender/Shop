using Shop.Business.Abstract;
using Shop.Business.Constants;
using Shop.Core_.Utilities.Results;
using Shop.DataAccess.Abstract;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal ?? throw new ArgumentNullException(nameof(brandDal));
        }

        public IResult AddBrand(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAllBrands()
        {
            var getAllBrands = _brandDal.GetAll();

            if (getAllBrands != null)
            {
                return new SuccessDataResult<List<Brand>>(getAllBrands);
            }
            else
            {
                return new ErrorDataResult<List<Brand>>(null, "Markalar bulunamadı");
            }

        }

        public IResult UpdateBrand(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult();
        }
    }
}
