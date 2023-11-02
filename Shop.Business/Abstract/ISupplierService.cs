using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface ISupplierService
    {
        // Tüm tedarikçileri getirir.
        IDataResult<List<Supplier>> GetAllSuppliers();

        // Belirli bir tedarikçi ID'sine göre tedarikçiyi getirir.
        IDataResult<Supplier> GetSupplierById(int supplierId);

        // Yeni bir tedarikçi ekler.
        IResult AddSupplier(Supplier supplier);

        // Mevcut bir tedarikçiyi günceller.
        IResult UpdateSupplier(Supplier supplier);

        // Belirli bir tedarikçi ID'sine göre tedarikçiyi siler.
        IResult DeleteSupplier(int supplierId);
    }
}
