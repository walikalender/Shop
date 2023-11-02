using Shop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities.Concrete
{
    public class Mold:IEntity
    {
        public int MoldId { get; set; }
        public string? MoldName { get; set; }
    }
}
