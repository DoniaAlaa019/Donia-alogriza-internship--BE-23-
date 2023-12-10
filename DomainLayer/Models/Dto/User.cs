using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Dto
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LasttName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string image { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
