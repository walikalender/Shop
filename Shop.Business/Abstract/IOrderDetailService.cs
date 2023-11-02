using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IOrderDetailService
    {
        //Tüm sipariş detaylarını getirir.
        IDataResult<List<OrderDetail>> GetAllOrderDetails();

        // Belirli bir sipariş ve ürün ID'sine göre sipariş detayını getirir.
        IDataResult<OrderDetail> GetOrderDetailById(int orderId, int productId);

        // Yeni bir sipariş detayı ekler.
        IResult AddOrderDetail(OrderDetail orderDetail);

        // Mevcut bir sipariş detayını günceller.
        IResult UpdateOrderDetail(OrderDetail orderDetail);

        // Bir sipariş detayını siler.
        IResult DeleteOrderDetail(OrderDetail orderDetail);

        // Belirli bir sipariş ID'sine ait tüm sipariş detaylarını getirir.
        IDataResult<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId);

        // Belirli bir ürün ID'sine ait tüm sipariş detaylarını getirir.
        IDataResult<List<OrderDetail>> GetOrderDetailsByProductId(int productId);
    }
}
