using System;
using System.Net.Http;
using ConsoleDemo;

swaggerClient client = new("https://localhost:44316", new HttpClient());
var records = await client.WeatherForecastAsync();

foreach (var r in records)
{
    Console.WriteLine($"{ r.Date }: { r.Summary }");
}