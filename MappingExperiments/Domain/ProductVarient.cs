using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingExperiments.Domain
{
    [AdaptTo("[name]CodeGenerateDto"), GenerateMapper]
    public class ProductVarient
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
