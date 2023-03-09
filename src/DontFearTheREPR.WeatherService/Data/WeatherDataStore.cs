namespace DontFearTheREPR.WeatherService.Data;

public class WeatherDataStore
{
    private static Dictionary<string, WeatherCondition> _weatherConditions = null!;

    public WeatherDataStore()
    {
        _weatherConditions = new Dictionary<string, WeatherCondition>();
    }

    public async Task AddWeatherCondition(WeatherCondition condition)
    {
        if (_weatherConditions.ContainsKey(condition.Location))
            _weatherConditions[condition.Location] = condition;
        else
            _weatherConditions.Add(condition.Location, condition);

        await Task.CompletedTask;
    }

    public async Task<WeatherCondition?> GetCurrentWeatherCondition(string zipCode)
    {
        if (_weatherConditions.ContainsKey(zipCode))
            return await Task.FromResult(_weatherConditions[zipCode]);
        
        return null;
    }
}