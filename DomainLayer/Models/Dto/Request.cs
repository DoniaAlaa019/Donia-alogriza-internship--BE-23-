using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Dto
{
    public class Request
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string State { get; set; }
        public string DiscountCode { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
