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
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal ?? throw new ArgumentNullException(nameof(supplierDal));
        }
        public IResult AddSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteSupplier(int supplierId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Supplier>> GetAllSuppliers()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Supplier> GetSupplierById(int supplierId)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
