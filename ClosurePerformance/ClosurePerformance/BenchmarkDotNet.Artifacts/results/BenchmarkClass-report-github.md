``` ini

BenchmarkDotNet=v0.10.6, OS=Windows 10 Redstone 1 (10.0.14393)
Processor=Intel Core i5-6260U CPU 1.80GHz (Skylake), ProcessorCount=4
Frequency=1757812 Hz, Resolution=568.8891 ns, Timer=TSC
dotnet cli version=1.0.4
  [Host]     : .NET Core 4.6.25211.01, 64bit RyuJIT
  DefaultJob : .NET Core 4.6.25211.01, 64bit RyuJIT


```
 |                   Method |     Mean |     Error |    StdDev |
 |------------------------- |---------:|----------:|----------:|
 |     ExecuteWithParameter | 10.64 ns | 0.0880 ns | 0.0823 ns |
 | ExecuteWithLocalVariable | 15.97 ns | 0.1411 ns | 0.1320 ns |
