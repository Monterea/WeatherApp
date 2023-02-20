using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Shared;
using System;


namespace WeatherApp { 
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IWeatherView  {
        //vkládáme prvky:
        ImageView imageViewWeather;
        TextView textViewCity;
        TextView textViewWeather;
        TextView textViewTemperature;
        TextView textViewHuminidy;
        TextView textViewWind;
        TextView textViewLocalTime;
        Button buttonChangeCity;
        WeatherService weatherService;  
        TextView textViewPressure;
        TextView textViewCloudcover;


        protected override void OnCreate(Bundle savedInstanceState)   {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);          
            SetContentView(Resource.Layout.activity_main);                                                     
            weatherService = new WeatherService(this);
            SetupReferences();
            SubscribeEventHandlers();
   }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults){
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void SetupReferences() {
            imageViewWeather = FindViewById<ImageView>(Resource.Id.imageViewPicture);
            textViewCity = FindViewById<TextView>(Resource.Id.textViewCity);
            textViewHuminidy = FindViewById<TextView>(Resource.Id.textViewHuminidy);
            textViewLocalTime = FindViewById<TextView>(Resource.Id.textViewLocalTime);
            textViewTemperature = FindViewById<TextView>(Resource.Id.textViewTemperature);
            textViewWeather = FindViewById<TextView>(Resource.Id.textViewWeather);
            textViewWind = FindViewById<TextView>(Resource.Id.textViewWind);
            buttonChangeCity = FindViewById<Button>(Resource.Id.buttonChangeCity);
            textViewPressure = FindViewById<TextView>(Resource.Id.textViewPressure);
            textViewCloudcover = FindViewById<TextView>(Resource.Id.textViewCloudcover);
        }

        private void SubscribeEventHandlers() {
            buttonChangeCity.Click += ButtonChangeCity_Click;
        }
         private void ButtonChangeCity_Click(object sender, EventArgs e) {
            Intent intent = new Intent(this, typeof(CitiesActivity));                    
            StartActivityForResult(intent, 1);              
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data) {
                if (requestCode==1 && resultCode == Result.Ok) {
                    string city = data.GetStringExtra("City");
                    textViewCity.Text = city;
                    weatherService.GetWeatherForCityAsync(city);
            }
        }
        public void SetWeatherData(WeatherModel weatherModel) {
            textViewCity.Text = weatherModel.Location.Name;
            textViewHuminidy.Text = $"{ weatherModel.Current.Humidity} %";
            textViewLocalTime.Text = weatherModel.Location.Localtime;
            textViewTemperature.Text = $"{weatherModel.Current.Temperature} °C";
            textViewWind.Text = $"azimut: {weatherModel.Current.Wind_dir}, {weatherModel.Current.Wind_speed} km/h";
            textViewCloudcover.Text = $"{weatherModel.Current.Cloudcover} %";
            textViewPressure.Text = $"{weatherModel.Current.Pressure} MB";
            textViewWeather.Text = weatherModel.Current.Weather_descriptions[0];
            imageViewWeather.SetImageBitmap(GetImageBitmapFromUrl(weatherModel.Current.Weather_icons[0]));
        }
        private Bitmap GetImageBitmapFromUrl(string url) {
            Bitmap imageBitmap = null;
            using (var webClient = new System.Net.WebClient()) {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0) {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }
            return imageBitmap;
        }
    }

    }
