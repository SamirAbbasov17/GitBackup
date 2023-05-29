``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i3-6006U CPU 2.00GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|   Method |      Mean |     Error |    StdDev |
|--------- |----------:|----------:|----------:|
| SBuilder |  2.433 μs | 0.0541 μs | 0.1561 μs |
|  SSimple | 11.523 μs | 0.2296 μs | 0.6514 μs |
