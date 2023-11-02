﻿using Shop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
    }
}
