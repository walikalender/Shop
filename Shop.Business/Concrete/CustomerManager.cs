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
    public class CustomerManager : ICustomerService
    {
       private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal ?? throw new ArgumentNullException(nameof(customerDal));
        }
        public IResult AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>();
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            _customerDal.Get(c => c.CustomerId == customerId);
            return new SuccessDataResult<Customer>();

        }

        public IResult UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
