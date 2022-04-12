using BenchmarkDotNet.Running;
using System;

namespace MappingExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MappingBenchmarks>();
            Console.WriteLine(summary);
        }
    }
}
