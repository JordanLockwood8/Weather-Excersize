using Newtonsoft.Json.Linq;

Console.WriteLine("Enter your City name");
string cityName = Console.ReadLine();
Console.WriteLine();


Console.WriteLine("Enter the API Key");
string key = Console.ReadLine();
Console.WriteLine();

var client = new HttpClient();
var weatherAppUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={key}";
var appResponse = client.GetStringAsync(weatherAppUrl).Result;
var weather = JObject.Parse(appResponse).GetValue("main");
Console.WriteLine($"The temp where you are is:{weather["temp"]} Degrees");