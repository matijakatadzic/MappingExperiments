using System;
using System.Collections.Generic;
using Sample.CodeGen.Models;

namespace Sample.CodeGen.Models
{
    public partial record ProductCodeGenerateDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public string ProductName { get; set; }
        public ProductVarientCodeGenerateDto DefaultOption { get; set; }
        public List<ProductVarientCodeGenerateDto> Options { get; set; }
    }
}