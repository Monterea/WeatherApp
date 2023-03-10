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
	public partial class Form1 : Form, IWeatherView {
		WeatherService weatherService;
		public Form1() {
			InitializeComponent();
			weatherService = new WeatherService(this);
		}

		public void SetWeatherData(WeatherModel weatherModel) {
			lbCity.Text = weatherModel.location.name;
			lbHumidity.Text = $"Humidity: {weatherModel.current.humidity.ToString()}";
			lbLocalTime.Text = $"Local time: {weatherModel.location.localtime}";
			lbTemperature.Text = $"Temperature: {weatherModel.current.temperature.ToString()} °C";
			lbWeather.Text = weatherModel.current.weather_descriptions[0];
			lbWind.Text = $"{weatherModel.current.wind_dir} {weatherModel.current.wind_speed}";
		}

		private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e) {
			string city = comboBoxCities.SelectedItem.ToString();
			weatherService.GetWeatherForCityAsync(city);
		}
	}
}
