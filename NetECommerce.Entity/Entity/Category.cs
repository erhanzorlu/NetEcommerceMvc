﻿using NetECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.Entity.Entity
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
