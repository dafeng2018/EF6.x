﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05
{
    public abstract class BillingDetail
    {
        public int BillingDetailId { get; set; }
        public String Owner { get; set; }

        public string Number { get; set; }
    }
}
