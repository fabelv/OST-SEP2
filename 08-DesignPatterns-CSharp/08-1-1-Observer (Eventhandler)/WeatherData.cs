using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Observer
{
    public sealed class WeatherData : WeatherAPI
    {
        

        protected override void MeasurementChanged()
        {
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var windSpeed = GetWindSpeed();
        }
    }
}
