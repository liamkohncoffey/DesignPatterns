using System.Collections.Generic;

namespace Observer.Observers
{
    public class DisplayBase : IObserver
    {
        public int Id { get; set; }

        private readonly ISubject _subject;
        private WeatherPayload _weatherPayload;

        public DisplayBase(ISubject subject)
        {
            _subject = subject;
            _weatherPayload = new WeatherPayload();
            _subject.RegisterObservers(new List<IObserver>
            {
                this
            });
        }
        
        public void Update(WeatherPayload payload)
        {
            _weatherPayload = payload;
        }
    }
}