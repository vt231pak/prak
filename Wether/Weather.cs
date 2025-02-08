using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace WeatherLibrary
{
    public class Weather
    {
        private string status;
        private double temperature;
        private double wind;
        private string windDirection;
        private double humidity;
        private double waterTemperature;
        private byte[] image;

        public Weather(string url)
        {
            LoadData(url);
        }

        public void LoadData(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string img = webClient.DownloadString("https://ua.sinoptik.ua/%D0%BF%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0-%D0%B6%D0%B8%D1%82%D0%BE%D0%BC%D0%B8%D1%80");
            Temperature = ExtractTemperature(html);
            Wind = ExtractWind(html);
            WindDirection = ExtractWindDirection(html);
            Humidity = ExtractHumidity(html);
            WaterTemperature = ExtractWaterTemperature(html);
            Status = ExtractStatus(html);
            string imgUrl = ExtractValue(img, "<div class=\"img\"> <img width=\"\\d+\" height=\"\\d+\" src=\"(//.+.jpg)\" ");
            byte[] imageData = webClient.DownloadData(imgUrl);
            Image = imageData;
        }

        private static string ExtractValue(string html, string pattern)
        {
            Regex regex = new Regex(pattern, RegexOptions.Compiled);
            Match match = regex.Match(html);
            return match.Success ? match.Groups[1].Value : "помилка";
        }

        private static double ExtractNumericValue(string html, string pattern)
        {
            string value = ExtractValue(html, pattern);
            return int.TryParse(value, out int result) ? result : 0;
        }

        private static string ExtractStatus(string html) =>
            ExtractValue(html, "<div class=\"now-desc\">(.+)</div><div class=\"now-info\">");

        private static string ExtractWindDirection(string html) =>
            ExtractValue(html, "м/c<br>([А-Яа-яІіЇї]+)</span>");

        private static double ExtractWaterTemperature(string html) =>
            ExtractNumericValue(html, "\"temperatureWater\":[([+-]?\\d+)],");

        private static double ExtractHumidity(string html) =>
            ExtractNumericValue(html, "\"humidity\":[(\\d+)],");

        private static double ExtractWind(string html) =>
            ExtractNumericValue(html, "windSpeed\":[(\\d+)]");

        private static double ExtractTemperature(string html) =>
            ExtractNumericValue(html, "class=\"now-weather\"><span class=\"unit-temperature\" data-temperature-f=\"\\d+\">([+-]?\\d+)</span>");

        public byte[] Image
        {
            get => image;
            set => image = value;
        }
        public string Status
        {
            get => status;
            set => status = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Temperature
        {
            get => temperature;
            set => temperature = value;
        }

        public double Wind
        {
            get => wind;
            set => wind = value;
        }

        public string WindDirection
        {
            get => windDirection;
            set => windDirection = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Humidity
        {
            get => humidity;
            set => humidity = value;
        }

        public double WaterTemperature
        {
            get => waterTemperature;
            set => waterTemperature = value;
        }
    }
}
