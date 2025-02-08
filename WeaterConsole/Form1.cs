using System.Net;
using System.Text;
using WeatherLibrary;

namespace WeaterConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather("https://meteofor.com.ua/weather-zhytomyr-4943/now/");
            temperature.Text = weather.Temperature.ToString() + " C";
            wind.Text = weather.Wind.ToString() + " m/c";
            windDirection.Text = weather.WindDirection.ToString();
            humidity.Text = weather.Humidity.ToString() + "%";
            waterTemperature.Text = weather.WaterTemperature.ToString() + " C";
            status.Text = weather.Status.ToString();
            using (var ms = new System.IO.MemoryStream(weather.Image))
            {
                Image img = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = img;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}