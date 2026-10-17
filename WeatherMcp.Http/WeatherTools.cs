using System.ComponentModel;
using ModelContextProtocol.Server;

[McpServerToolType]
public sealed class WeatherTools
{
    [McpServerTool(Name = "get_forecast")]
    [Description("Returns a short weather forecast for a city.")]
    public static string GetForecast(
        [Description("City name, for example London")] string city)
    {
        // Mock data. A real tool would call a weather API here.
        return $"{city}: 18C, light rain expected this afternoon.";
    }
}
