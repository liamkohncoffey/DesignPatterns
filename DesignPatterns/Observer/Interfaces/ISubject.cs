using System.Collections.Generic;

namespace Observer
{
    public interface ISubject
    {
        public void RegisterObservers(IEnumerable<IObserver> observers);
        public void RemoveObserver(IEnumerable<IObserver> observers);
        public void NotifyObservers(WeatherPayload payload);
    }
}