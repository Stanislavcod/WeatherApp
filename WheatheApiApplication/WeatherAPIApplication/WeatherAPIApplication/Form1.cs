using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WeatherAPIApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VissibleIgnor();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
            GetForecast();
            VissibleIgnorTrue();
        }

        string APIKey = "53c69a068e4b007bcdb3a1f5bb576ae4";

        double lon;
        double lat;
        void GetWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", TBCity.Text, APIKey);
                    var json = web.DownloadString(url);
                    WeatherData.root Info = JsonConvert.DeserializeObject<WeatherData.root>(json);

                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labelCondition.Text = Info.weather[0].main;
                    labelDetails.Text = Info.weather[0].description;
                    labelSunriseN_A.Text = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();
                    labelSunsetN_A.Text = ConvertDateTime(Info.sys.sunset).ToShortTimeString();

                    labelWindSpeedN_A.Text = Info.wind.speed.ToString();
                    labelPressureN_A.Text = Info.main.pressure.ToString();
                    labelHumidityH_A.Text = Info.main.humidity.ToString();
                    labelTempN_A.Text = Info.main.temp.ToString();

                    lon = Info.coord.lon;
                    lat = Info.coord.lat;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops,The city was not found");
            }
        }
        void GetForecast()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&units=metric&exclude=current,minutely,hourly,alerts&appid={2}", lat,lon, APIKey);
                    var json = web.DownloadString(url);
                    WeatherForecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                    ForecasrUC FUC;
                    for (int i = 0; i < 8; i++)
                    {
                        FUC = new ForecasrUC();
                        FUC.pictWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ".png";
                        FUC.labelMainWeather.Text = forecastInfo.daily[i].weather[0].main;
                        FUC.labWeatherDescription.Text = forecastInfo.daily[i].weather[0].description;
                        FUC.labelDT.Text = ConvertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();
                        FLP.Controls.Add(FUC);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops,The city was not found");
            }
        }

        public DateTime ConvertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }


        public void VissibleIgnor()
        {
            labelTempN_A.Visible = false;
            labelSunsetN_A.Visible = false;
            labelSunriseN_A.Visible = false;
            labelPressureN_A.Visible = false;
            labelHumidityH_A.Visible = false;
            labelWindSpeedN_A.Visible = false;
        }
        public void VissibleIgnorTrue()
        {
            labelTempN_A.Visible = true;
            labelSunsetN_A.Visible = true;
            labelSunriseN_A.Visible = true;
            labelPressureN_A.Visible = true;
            labelHumidityH_A.Visible = true;
            labelWindSpeedN_A.Visible = true;
        }
    }
}
