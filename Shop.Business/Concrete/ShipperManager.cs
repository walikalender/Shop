using Shop.Business.Abstract;
using Shop.Core_.Utilities.Results;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.Entityframework;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    public class ShipperManager : IShipperService
    {
        private readonly IShipperDal _shipperDal;
        public ShipperManager(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal ?? throw new ArgumentNullException(nameof(shipperDal));
        }
        public IResult AddShipper(Shipper shipper)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteShipper(int shipperId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Shipper>> GetAllShippers()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Shipper> GetShipperById(int shipperId)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateShipper(Shipper shipper)
        {
            throw new NotImplementedException();
        }
    }
}
