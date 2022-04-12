using System;

namespace Sample.CodeGen.Models
{
    public partial record ProductVarientCodeGenerateDto
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}