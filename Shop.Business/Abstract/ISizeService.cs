using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface ISizeService
    {
        // Tüm bedenleri getirir.
        IDataResult<List<Size>> GetAllSizes();

        // Belirli bir beden ID'sine göre bedeni getirir.
        IDataResult<Size> GetSizeById(int sizeId);

        // Yeni bir beden ekler.
        IResult AddSize(Size size);

        // Mevcut bir bedeni günceller.
        IResult UpdateSize(Size size);

        // Belirli bir beden ID'sine göre bedeni siler.
        IResult DeleteSize(int sizeId);
    }
}
