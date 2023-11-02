using Shop.Core_.DataAccess.Concrete.Entityframework;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.Context;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataAccess.Concrete.Entityframework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ShopContext>, IBrandDal
    {
    }
}
