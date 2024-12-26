using crud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Models
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string AddressNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public ICollection<CreateProductDto> Products { get; set; } = new List<CreateProductDto>();
    }
}
