using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IMoldService
    {
        // Yeni bir kalıp ekler.
        IResult AddMold(Mold mold);

        // Belirli bir kalıp ID'sine göre kalıbı siler.
        IResult DeleteMold(Mold mold);

        // Mevcut bir kalıbı günceller.
        IResult UpdateMold(Mold mold);

        // Tüm kalıpları getirir.
        IDataResult<List<Mold>> GetAllMolds();
    }
}
