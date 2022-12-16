// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;

using var client = new HttpClient();
var response = await client.GetFromJsonAsync<WeatherApi.WeatherForecast[]>("https://localhost:7077/WeatherForecast");

if (response == null) {
    Console.WriteLine("No response");
    return;
}

foreach (var item in response)
{
    Console.WriteLine($"{item.Date} - {item.Summary} - {item.TemperatureF} F / {item.TemperatureC} C");
}