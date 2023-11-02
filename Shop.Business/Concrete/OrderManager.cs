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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal ?? throw new ArgumentNullException(nameof(orderDal));
        }
        public IResult AddOrder(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult();
        }

        public IResult DeleteOrder(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();
        }

        public IDataResult<List<Order>> GetAllOrders()
        {
            _orderDal.GetAll();
            return new SuccessDataResult<List<Order>>();    
        }

        public IDataResult<Order> GetOrderById(int orderId)
        {
            _orderDal.Get(o => o.OrderId == orderId);
            return new SuccessDataResult<Order>();
        }

        public IDataResult<List<Order>> GetOrdersByCustomerId(string customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetOrdersByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetOrdersByShipCountry(string shipCountry)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetOrdersShippedAfter(DateTime shippedDate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetOrdersShippedBefore(DateTime shippedDate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetOrdersShippedBetweenDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateOrder(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();
        }
    }
}
