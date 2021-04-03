using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TCustomer : Customer //coorporate(tüzel) customer -- inheritance
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
