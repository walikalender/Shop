using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IBrandService
    {
        // Yeni bir marka ekler.
        IResult AddBrand(Brand brand);

        // Bir markayı siler.
        IResult DeleteBrand(Brand brand);

        // Mevcut bir markayı günceller.
        IResult UpdateBrand(Brand brand);

        // Tüm markaları getirir.
        IDataResult<List<Brand>> GetAllBrands();
    }
}
