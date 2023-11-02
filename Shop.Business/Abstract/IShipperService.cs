using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IShipperService
    {
        // Tüm shipper'ları getirir.
        IDataResult<List<Shipper>> GetAllShippers();

        // Belirli bir shipper ID'sine göre shipper'ı getirir.
        IDataResult<Shipper> GetShipperById(int shipperId);

        // Yeni bir shipper ekler.
        IResult AddShipper(Shipper shipper);

        // Mevcut bir shipper'ı günceller.
        IResult UpdateShipper(Shipper shipper);

        // Belirli bir shipper ID'sine göre shipper'ı siler.
        IResult DeleteShipper(int shipperId);
    }
}
