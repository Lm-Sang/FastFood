using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO
{
    public class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int AccountId { get; set; }
        [Required]
        public string Username { get; set; }

        [Required()]
        public string Password { get; set; }
        [Required()]
        public string Name { get; set; }

        [Required()]
        public string Role { get; set; } = "STAFF";

        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
