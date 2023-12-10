using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Dto
{
    public class Discount
    {
        public int Id { get; set; }
        public string DiscountCode { get; set; }
        public int ConfirmedRequestNumber { get; set; }

        public string DiscountType { get; set;}
        public double Value { get; set; }
    }
}
