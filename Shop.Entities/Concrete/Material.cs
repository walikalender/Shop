using Shop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities.Concrete
{
    public class Material:IEntity
    {
        public int MaterialId { get; set; }
        public string? MaterialName { get; set; }
    }
}
