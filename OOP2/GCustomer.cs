using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GCustomer : Customer //gerçek müsteri individual -- inheritance
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
