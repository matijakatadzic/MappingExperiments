using MappingExperiments.Domain;
using Sample.CodeGen.Models;

namespace Sample.CodeGen.Models
{
    public static partial class ProductVarientMapper
    {
        public static ProductVarientCodeGenerateDto AdaptToCodeGenerateDto(this ProductVarient p1)
        {
            return p1 == null ? null : new ProductVarientCodeGenerateDto()
            {
                Id = p1.Id,
                Color = p1.Color,
                Size = p1.Size
            };
        }
        public static ProductVarientCodeGenerateDto AdaptTo(this ProductVarient p2, ProductVarientCodeGenerateDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            ProductVarientCodeGenerateDto result = p3 ?? new ProductVarientCodeGenerateDto();
            
            result.Id = p2.Id;
            result.Color = p2.Color;
            result.Size = p2.Size;
            return result;
            
        }
    }
}