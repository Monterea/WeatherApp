using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWeather {
    public partial class Form1 : Form,IWeatherView {
        WeatherService weatherService;
        public Form1() {
            InitializeComponent();
            weatherService = new WeatherService(this);
        }
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            string city = comboBoxCities.SelectedItem.ToString();//pozor selectedItem převádí na object a tak se musí použít  ToString()
            weatherService.GetWeatherForCityAsync(city);
        }
        public void SetWeatherData(WeatherModel weatherModel) {
            lbCity.Text = weatherModel.Location.Name;
            lbHuminidy.Text = $"{ weatherModel.Current.Humidity.ToString()} %";
            lbLocalTime.Text = weatherModel.Location.Localtime;
            lbTemperature.Text = $"{weatherModel.Current.Temperature.ToString()} °C";
            lbWind.Text = $"{weatherModel.Current.Wind_dir}  {weatherModel.Current.Wind_speed} km/h";//wind-dir je azimut větru
            lbCloudcover.Text = $"{weatherModel.Current.Cloudcover.ToString()} %";
            lbPressure.Text = $"{weatherModel.Current.Pressure.ToString()} MB";
            lbWeather.Text = weatherModel.Current.Weather_descriptions[0];

        }
        //po uzavření comboBoxu

    }
}
