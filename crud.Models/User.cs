using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string AddressNo { get; set; }
        [MaxLength(250)]
        public string Street { get; set; }
        [MaxLength(250)]
        [Required]
        public string City { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
