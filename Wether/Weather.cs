using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class Weather
    {
        private readonly HttpClient httpClient = new HttpClient();
        
        public string Status { get; private set; }
        public double Temperature { get; private set; }
        public double Wind { get; private set; }
        public string WindDirection { get; private set; }
        public double Humidity { get; private set; }
        public double WaterTemperature { get; private set; }
        public byte[] Image { get; private set; }

        public Weather(string url) => LoadDataAsync(url).Wait();

        private async Task LoadDataAsync(string url)
        {
            try
            {
                string html = await httpClient.GetStringAsync(url);
                Temperature = ExtractDoubleValue(html, "class=\"now-weather\"><span class=\"unit-temperature\".*?>([+-]?\\d+\\.?\\d*)</span>");
                Wind = ExtractDoubleValue(html, "windSpeed\":[(\\d+\\.?\\d*)]");
                WindDirection = ExtractValue(html, "м/c<br>([А-Яа-яІіЇї]+)</span>");
                Humidity = ExtractDoubleValue(html, "\"humidity\":[(\\d+)]");
                WaterTemperature = ExtractDoubleValue(html, "\"temperatureWater\":[([+-]?\\d+\\.?\\d*)]");
                Status = ExtractValue(html, "<div class=\"now-desc\">(.+)</div><div class=\"now-info\">");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка завантаження даних: {ex.Message}");
            }
        }

        private static string ExtractValue(string html, string pattern)
        {
            Match match = Regex.Match(html, pattern, RegexOptions.Compiled);
            return match.Success ? match.Groups[1].Value : "Невідомо";
        }

        private static double ExtractDoubleValue(string html, string pattern)
        {
            string value = ExtractValue(html, pattern);
            return double.TryParse(value, out double result) ? result : 0;
        }
    }
}
