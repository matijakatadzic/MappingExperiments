using AutoMapper;
using MappingExperiments.Domain;
using MappingExperiments.Dtos;
using Mapster;
using Sample.CodeGen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingExperiments
{
    public static class MappingSamples
    {
        private static readonly IMapper AutoMaper =
            new Mapper(new MapperConfiguration(x => x.AddProfile(new AutomapperProfile())));

        private static readonly TypeAdapterConfig TypeAdapterConfig = GetTypeAdapterConfig();
        private static readonly MapsterMapper.IMapper MapsterMapper = new MapsterMapper.Mapper(TypeAdapterConfig);


        private static TypeAdapterConfig GetTypeAdapterConfig()
        {
            var config = new TypeAdapterConfig();
            config.NewConfig<Product, ProductDto>();
            return config;
        }

        internal static ProductDto MapsterAdaptWithConfigSample()
        {
            return GenerateProduct.Adapt<ProductDto>(TypeAdapterConfig);
        }

        internal static ProductDto MapsterAdaptWithoutConfigSample()
        {
            return GenerateProduct.Adapt<ProductDto>();
        }

        internal static ProductCodeGenerateDto MapsterAdaptCodeGenerationSample()
        {
            return GenerateProduct.AdaptToCodeGenerateDto();
        }

        internal static ProductDto MapsterAdaptToTypeSample()
        {
            return MapsterMapper.From(GenerateProduct).AdaptToType<ProductDto>();
        }
        static MappingSamples()
        {
            ExpressMapper.Mapper.Register<Product, ProductDto>();
        }

        internal static ProductDto ManualMapSample()
        {
            var product = GenerateProduct;
            return new ProductDto
            {
                Id = product.Id,
                Description = product.Description,
                Weight = product.Weight,
                ProductName = product.ProductName,
                DefaultOption = new ProductVarientDto
                {
                    Id = product.DefaultOption.Id,
                    Color = product.DefaultOption.Color,
                    Size = product.DefaultOption.Size
                },
                Options = product.Options.Select(x => new ProductVarientDto
                {
                    Id = x.Id,
                    Color = x.Color,
                    Size = x.Size
                }).ToList()
            };
        }

        internal static ProductDto ExpressMapperSample()
        {
            return ExpressMapper.Mapper.Map<Product, ProductDto>(GenerateProduct);
        }

        internal static ProductDto AutoMapperSample()
        {
            return AutoMaper.Map<ProductDto>(GenerateProduct);
        }

        public static readonly Product GenerateProduct = new Product()
        {
            Id = Guid.Parse("890f7ab8-2ee3-4a5b-955d-72797b0ffbd8"),
            Description = "This is some desc!",
            Weight = 12m,
            ProductName = "Mappers in their best",
            DefaultOption = new ProductVarient()
            {
                Id = Guid.Parse("890f7ab8-2ee3-4a5b-955d-72797b0ffbd8"),
                Color = "Blue",
                Size = "L"
            },
            Options = new List<ProductVarient>
            {
                new ProductVarient
                {
                    Id = Guid.Parse("890f7ab8-2ee3-4a5b-955d-72797b0ffbd8"),
                    Color = "Blue",
                    Size = "L"
                },
                new ProductVarient
                {
                    Id = Guid.Parse("890f7ab8-2ee3-4a5b-955d-72797b0ffbd8"),
                    Color = "Red",
                    Size = "S"
                },
                new ProductVarient
                {
                    Id = Guid.Parse("890f7ab8-2ee3-4a5b-955d-72797b0ffbd8"),
                    Color = "Black",
                    Size = "M"
                },
                new ProductVarient
                {
                    Id = Guid.Parse("890f7ab8-2ee3-4a5b-955d-72797b0ffbd8"),
                    Color = "Green",
                    Size = "S"
                }
            }
        };
    }


    internal class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ProductVarient, ProductVarientDto>();
            CreateMap<Product, ProductDto>();

        }
    }
}
