using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest.Model
{
    class OrderTrucks
    {
        public String driverName { get; set; }
        public String customerID { get; set; }
        public Customer customer { get; set; }
        public String materialType { get; set; }
        public int subtotal { get; set; }
        public String note { get; set; }
        public String createDate { get; set; }
        public String modifyDate { get; set; }


    }
}
