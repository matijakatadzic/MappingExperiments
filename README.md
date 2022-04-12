# MappingExperiments
AutoMaper, Expressmapper and Mapster


|                           Method |      Mean |    Error |   StdDev |    Median | Rank |  Gen 0 | Allocated |
|--------------------------------- |----------:|---------:|---------:|----------:|-----:|-------:|----------:|
| MapsterAdaptCodeGenerationSample |  75.42 ns | 1.502 ns | 2.006 ns |  75.45 ns |    1 | 0.0975 |     408 B |
|  MapsterAdaptWithoutConfigSample | 103.66 ns | 2.073 ns | 4.762 ns | 101.91 ns |    2 | 0.0975 |     408 B |
|                        ManualMap | 114.96 ns | 2.293 ns | 2.252 ns | 114.09 ns |    3 | 0.1147 |     480 B |
|     MapsterAdaptWithConfigSample | 131.35 ns | 1.507 ns | 1.409 ns | 131.98 ns |    4 | 0.0975 |     408 B |
|         MapsterAdaptToTypeSample | 152.48 ns | 1.526 ns | 1.274 ns | 152.49 ns |    5 | 0.1070 |     448 B |
|                       AutoMapper | 197.56 ns | 3.698 ns | 3.459 ns | 197.21 ns |    6 | 0.0975 |     408 B |
|                   ExpressMapping | 298.35 ns | 3.535 ns | 3.306 ns | 298.10 ns |    7 | 0.1373 |     576 B |
