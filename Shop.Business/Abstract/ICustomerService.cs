using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface ICustomerService
    {
        // Yeni bir müşteri ekler.
        IResult AddCustomer(Customer customer);

        // Bir müşteriyi siler.
        IResult DeleteCustomer(Customer customer);

        // Mevcut bir müşteriyi günceller.
        IResult UpdateCustomer(Customer customer);

        // Belirli bir müşteri ID'sine göre müşteriyi getirir.
        IDataResult<Customer> GetCustomerById(int customerId);

        // Tüm müşterileri getirir.
        IDataResult<List<Customer>> GetAllCustomers();
    }
}
