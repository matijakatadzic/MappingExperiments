using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingExperiments.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public string ProductName { get; set; }
        public ProductVarientDto DefaultOption { get; set; }
        public List<ProductVarientDto> Options { get; set; }
    }
}
