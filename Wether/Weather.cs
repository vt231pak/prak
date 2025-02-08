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
            string imgUrl = ExtractImage(img);
            byte[] imageData = webClient.DownloadData(imgUrl);
            Image = imageData;
        }
        private static string ExtractImage(string html)
        {
            Regex regex =
                new Regex(" <div class=\"img\"> <img width=\"\\d+\" height=\"\\d+\" src=\"(\\/\\/.+\\.jpg)\" ", RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                return "https:"+match.Groups[1].Value;
            }
            else return "помилка";
        }
        private static string ExtractStatus(string html)
        {
            Regex regex =
                new Regex("<div class=\"now-desc\">(.+)<\\/div><div class=\"now-info\">",RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else return "помилка";
        }
        private static string ExtractWindDirection(string html)
        {
            Regex regex =
                new Regex("м\\/c<br>([А-Яа-яІіЇї]+)<\\/span>", RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else return "помилка";
        }
        private static double ExtractWaterTemperature(string html)
        {
            Regex regex =
                new Regex("\"temperatureWater\":\\[([+-]?\\d+)\\],",RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                string text = match.Groups[1].Value;
                return int.Parse(text);
            }
            else return 0;
        }
        private static double ExtractHumidity(string html)
        {
            Regex regex =
                new Regex("\"humidity\":\\[(\\d+)\\],",RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                string text = match.Groups[1].Value;
                return int.Parse(text);
            }
            else return 0;
        }
        private static double ExtractWind(string html)
        {
            Regex regex =
                new Regex("windSpeed\":\\[(\\d+)\\]",RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                string text = match.Groups[1].Value;
                return int.Parse(text);
            }
            else return 0;
        }
        private static double ExtractTemperature(string html)
        {
            Regex regex =
                new Regex(
                    "class=\"now-weather\"><span class=\"unit-temperature\" data-temperature-f=\"\\d+\">([+-]?\\d+)<\\/span>",
                    RegexOptions.Compiled);
            Match match = regex.Match(html);
            if (match.Success)
            {
                string text = match.Groups[1].Value;
                return int.Parse(text);
            }
            else return 0;
        }
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