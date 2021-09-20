namespace Observer
{
    public interface IObserver
    {
        public int Id { get; set; }
        public void Update(WeatherPayload payload);
    }
}