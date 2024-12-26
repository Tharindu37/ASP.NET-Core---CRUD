using crud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Models
{
    public class UpdateProductDto
    {
        [Required(ErrorMessage ="You must enter a name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ProductStatus Status { get; set; }
    }
}
