using BenchmarkDotNet.Attributes;
using MappingExperiments.Dtos;
using Sample.CodeGen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingExperiments
{
    [MemoryDiagnoser, Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class MappingBenchmarks
    {
        [Benchmark]
        public ProductDto ManualMap() => MappingSamples.ManualMapSample();

        [Benchmark]
        public ProductDto ExpressMapping() => MappingSamples.ExpressMapperSample();

        [Benchmark]
        public ProductDto AutoMapper() => MappingSamples.AutoMapperSample();

        [Benchmark]
        public ProductDto MapsterAdaptWithoutConfigSample() => MappingSamples.MapsterAdaptWithoutConfigSample();

        [Benchmark]
        public ProductDto MapsterAdaptWithConfigSample() => MappingSamples.MapsterAdaptWithConfigSample();

        [Benchmark]
        public ProductDto MapsterAdaptToTypeSample() => MappingSamples.MapsterAdaptToTypeSample();

        [Benchmark]
        public ProductCodeGenerateDto MapsterAdaptCodeGenerationSample() => MappingSamples.MapsterAdaptCodeGenerationSample();
    }
}
