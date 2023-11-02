using Shop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int BrandId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int MoldId { get; set; }
        public int MaterialId { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string? Description { get; set; }
        public int Discount { get; set; }
        public short ReorderLevel { get; set; }
        public string? ImageUrl { get; set; }
        public List<User>? Users { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
