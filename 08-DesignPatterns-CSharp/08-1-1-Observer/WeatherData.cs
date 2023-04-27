using System.Collections.Generic;

namespace Observer
{
    public sealed class WeatherData : WeatherAPI, IWeatherData
    {
        private List<IView> _observers = new List<IView>();

        public void Attach(IView view)
        {
            _observers.Add(view);
        }

        public void Unattach(IView view)
        {
            _observers.Remove(view);
        }

        protected override void MeasurementChanged()
        {
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var windSpeed = GetWindSpeed();

            foreach (var observer in _observers)
            {
                observer.Update(temperature, humidity, windSpeed);
            }
        }
    }
}
