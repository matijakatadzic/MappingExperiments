using System.Collections.Generic;
using MappingExperiments.Domain;
using Sample.CodeGen.Models;

namespace Sample.CodeGen.Models
{
    public static partial class ProductMapper
    {
        public static ProductCodeGenerateDto AdaptToCodeGenerateDto(this Product p1)
        {
            return p1 == null ? null : new ProductCodeGenerateDto()
            {
                Id = p1.Id,
                Description = p1.Description,
                Weight = p1.Weight,
                ProductName = p1.ProductName,
                DefaultOption = p1.DefaultOption == null ? null : new ProductVarientCodeGenerateDto()
                {
                    Id = p1.DefaultOption.Id,
                    Color = p1.DefaultOption.Color,
                    Size = p1.DefaultOption.Size
                },
                Options = funcMain1(p1.Options)
            };
        }
        public static ProductCodeGenerateDto AdaptTo(this Product p3, ProductCodeGenerateDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            ProductCodeGenerateDto result = p4 ?? new ProductCodeGenerateDto();
            
            result.Id = p3.Id;
            result.Description = p3.Description;
            result.Weight = p3.Weight;
            result.ProductName = p3.ProductName;
            result.DefaultOption = funcMain2(p3.DefaultOption, result.DefaultOption);
            result.Options = funcMain3(p3.Options, result.Options);
            return result;
            
        }
        
        private static List<ProductVarientCodeGenerateDto> funcMain1(List<ProductVarient> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<ProductVarientCodeGenerateDto> result = new List<ProductVarientCodeGenerateDto>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                ProductVarient item = p2[i];
                result.Add(item == null ? null : new ProductVarientCodeGenerateDto()
                {
                    Id = item.Id,
                    Color = item.Color,
                    Size = item.Size
                });
                i++;
            }
            return result;
            
        }
        
        private static ProductVarientCodeGenerateDto funcMain2(ProductVarient p5, ProductVarientCodeGenerateDto p6)
        {
            if (p5 == null)
            {
                return null;
            }
            ProductVarientCodeGenerateDto result = p6 ?? new ProductVarientCodeGenerateDto();
            
            result.Id = p5.Id;
            result.Color = p5.Color;
            result.Size = p5.Size;
            return result;
            
        }
        
        private static List<ProductVarientCodeGenerateDto> funcMain3(List<ProductVarient> p7, List<ProductVarientCodeGenerateDto> p8)
        {
            if (p7 == null)
            {
                return null;
            }
            List<ProductVarientCodeGenerateDto> result = new List<ProductVarientCodeGenerateDto>(p7.Count);
            
            int i = 0;
            int len = p7.Count;
            
            while (i < len)
            {
                ProductVarient item = p7[i];
                result.Add(item == null ? null : new ProductVarientCodeGenerateDto()
                {
                    Id = item.Id,
                    Color = item.Color,
                    Size = item.Size
                });
                i++;
            }
            return result;
            
        }
    }
}