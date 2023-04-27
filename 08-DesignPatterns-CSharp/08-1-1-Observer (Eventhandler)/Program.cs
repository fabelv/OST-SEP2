namespace Observer
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            weatherData.Attach(new ConsoleView(1));
            weatherData.Attach(new ConsoleView(2));

            weatherData.StartAsync().Wait();
        }
    }
}
