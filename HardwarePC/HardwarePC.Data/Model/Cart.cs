﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwarePC.Data.Model
{
    public class Cart : IdentityBase
    {
        public Cart()
        {
            this.CartItem = new HashSet<CartItem>();
        }

        public string Cookie { get; set; }
        public System.DateTime CartDate { get; set; }
        public int ItemCount { get; set; }


        public virtual ICollection<CartItem> CartItem { get; set; }
    }
}


