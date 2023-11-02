using Shop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public List<Product>? DiscountedProducts { get; set; }
    }
}
