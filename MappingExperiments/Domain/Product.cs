using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingExperiments.Domain
{
    [AdaptTo("[name]CodeGenerateDto"), GenerateMapper]
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public string ProductName { get; set; }
        public ProductVarient DefaultOption { get; set; }
        public List<ProductVarient> Options { get; set; }
    }
}
