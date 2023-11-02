using Shop.Business.Abstract;
using Shop.Business.Constants;
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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal ?? throw new ArgumentNullException(nameof(orderDetailDal));
        }
        public IResult AddOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult();
        }

        public IResult DeleteOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
            return new SuccessResult();
        }

        public IDataResult<List<OrderDetail>> GetAllOrderDetails()
        {
            _orderDetailDal.GetAll();
            return new SuccessDataResult<List<OrderDetail>>();
        }

        public IDataResult<OrderDetail> GetOrderDetailById(int orderId, int productId)
        {
            var orderDetail = _orderDetailDal.Get(o => o.OrderId == orderId && o.ProductId == productId);

            if (orderDetail != null)
            {
                return new SuccessDataResult<OrderDetail>(orderDetail);
            }
            else
            {
                return new ErrorDataResult<OrderDetail>(null,"sipariş detayı bulunamadı");
            }
        }


        public IDataResult<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OrderDetail>> GetOrderDetailsByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
            return new SuccessResult();
        }
    }
}
