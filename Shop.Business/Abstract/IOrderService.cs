using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAllOrders();
        IDataResult<Order> GetOrderById(int orderId);
        IResult AddOrder(Order order);
        IResult UpdateOrder(Order order);
        IResult DeleteOrder(Order order);
        IDataResult<List<Order>> GetOrdersByCustomerId(string customerId); // Belirli bir müşteriye ait siparişleri getirir.
        IDataResult<List<Order>> GetOrdersByEmployeeId(int employeeId); // Belirli bir çalışana ait siparişleri getirir.
        IDataResult<List<Order>> GetOrdersByShipCountry(string shipCountry); // Belirli bir ülkeye gönderilmiş siparişleri getirir.
        IDataResult<List<Order>> GetOrdersShippedAfter(DateTime shippedDate); // Belirli bir tarihten sonra gönderilmiş siparişleri getirir.
        IDataResult<List<Order>> GetOrdersShippedBefore(DateTime shippedDate); // Belirli bir tarihten önce gönderilmiş siparişleri getirir.
        IDataResult<List<Order>> GetOrdersShippedBetweenDates(DateTime startDate, DateTime endDate); // Belirli iki tarih arasında gönderilmiş siparişleri getirir.
    }

}
