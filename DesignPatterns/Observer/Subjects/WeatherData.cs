using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private WeatherPayload _weatherPayload;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObservers(IEnumerable<IObserver> observers)
        {
            _observers.AddRange(observers);
        }

        public void RemoveObserver(IEnumerable<IObserver> observers)
        {
            foreach (var observer in observers) 
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers(WeatherPayload payload)
        {
            foreach (var observer in _observers)
            {
                observer.Update(payload);
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers(_weatherPayload);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _weatherPayload = new WeatherPayload
            {
                Humidity = humidity,
                Pressure = pressure,
                Temperature = temperature
            };
            MeasurementsChanged();
        }
    }
}