using Newtonsoft.Json.Linq;

while (true)
{
    var apiKey = "4e99177b2c127e79c383e270d2da5803";


    Console.WriteLine("Enter city name");
    var cityName = Console.ReadLine();
    var client = new HttpClient();


    var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";


    var weatherResponse = client.GetStringAsync(weatherMapURL).Result;
    var weatherSetUp = JObject.Parse(weatherResponse).GetValue("main").ToString();

    var temp = JObject.Parse(weatherSetUp).GetValue("temp");
    
    
  
    
        
        Console.WriteLine($"The current Temp is {temp} degrees Fahrenheit in {cityName}");
    

    Console.WriteLine("Would you like to exit ?");
    var userInput = Console.ReadLine();



    if (userInput.ToLower().Trim() == "yes")
    {
        break;
    }


}
