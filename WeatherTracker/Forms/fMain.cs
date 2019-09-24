using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using System.IO;
using WeatherTracker.Classes;

namespace WeatherTracker.Forms
{
    public partial class fMain : Form
    {
        fSplash splashForm = new fSplash();

        fAbout aboutForm = new fAbout();

        //fOptions optionsForm = new fOptions();

        RootObject weatherData = new RootObject();

        public fMain()
        {
            InitializeComponent();

            splashForm.Show();

            Application.DoEvents();
        }

        /// <summary>
        /// Closes the app.
        /// </summary>
        private void ShutDown()
        {
            if (notifyWeather.Visible)
            {
                notifyWeather.Visible = false;
            }

            Application.Exit();
        }

        /// <summary>
        /// Restores fMain.
        /// </summary>
        private void Restore()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            Visible = true;
        }

        /// <summary>
        /// Set values to UI elements.
        /// </summary>
        private void UpdateUI()
        {
            pbConditionsDescription.Image = new Bitmap(typeof(WeatherTracker.Resources.Image), "0cloud.png");
            //string condition = weatherData.WeatherConditions[0].Description;
            lblLocation.Text = $"Location: {weatherData.Sys.Country}, {weatherData.Name}";
            lblTemperature.Text = $"{weatherData.Main.Temp:#.#} \u00B0C";
            lblPressure.Text = $"{weatherData.Main.Pressure}hPa";
            lblWindSpeed.Text = $"{weatherData.Wind.Speed} meter/sec";
            lblWindDirection.Text = $"{weatherData.Wind.Deg} degrees";
        }

        //private void SetWeatherValues() {
        //    this.SetWeatherPicture( weather.Condition.Text );

        //    weather.Units = units;

        //    // τοποθεσία
        //    if (weather.Location.City == "Salonica")
        //        weather.Location.City = "Θεσσαλονίκη";
        //    if (weather.Location.Country == "GR")
        //        weather.Location.Country = "Ελλάδα";
        //    lblLocation.Text =  "Περιοχή: " + weather.Location.City + ", " + weather.Location.Country;
            
        //    // μονάδες μέτρησης
        //    lblUnitsTemperature.Text = weather.Units.Temperature.ToString();
        //    lblDistance.Text = weather.Units.Distance.ToString();
        //    lblPressure.Text = weather.Units.Pressure.ToString();
        //    lblUnitSpeed.Text = weather.Units.Speed.ToString();

        //    // άνεμος
        //    lblChill.Text = weather.Wind.Chill.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //    lblDirection.Text = weather.Wind.Direction.ToString() + " μοίρες";
        //    lblWindSpeed.Text = "με "+ weather.Wind.Speed.ToString() + " " + weather.Units.GetSpeedUnitAbbreviation();

        //    // ατμόσφαιρα
        //    lblHumidity.Text = weather.Atmosphere.Humidity.ToString() + "%";
        //    lblVisibility.Text = weather.Atmosphere.Visibility.ToString() + " " + weather.Units.GetDistanceUnitAbbreviation();
        //    lblAtmoPressure.Text = String.Format("{0:#.##}", weather.Atmosphere.Pressure) + " " + weather.Units.GetPressureUnitAbbreviation();
        //    lblAtmoRising.Text = " - " + weather.Atmosphere.Rising.ToString();

        //    // αστρονομία
        //    lblSunrise.Text = weather.Astronomy.Sunrise.ToShortTimeString();
        //    lblSunset.Text = weather.Astronomy.Sunset.ToShortTimeString();


        //    // γεωγραφία
        //    lblLatitude.Text = weather.Geography.Latitude.ToString(); 
        //    lblLongitude.Text = weather.Geography.Longitude.ToString(); 

        //    // καιρικές συνθήκες
        //    lblConditions.Text = weather.Condition.Text;
        //    if (weather.Condition.Text == "Partly Cloudy")
        //        lblConditions.Text = "Αραιή Συννεφιά";
        //    else if (weather.Condition.Text == "Mostly Cloudy")
        //        lblConditions.Text = "Αυξημένη Συννεφιά";
        //    lblCode.Text = weather.Condition.Code.ToString();
        //    lblTemperature.Text = weather.Condition.Temperature.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //    lblDate.Text = weather.Condition.Date.ToLongDateString();
            
        //    // πρόβλεψη μιας ημέρας
        //    lblForecast1Date.Text = weather.Forecast.Days[0].Date.ToShortDateString();
        //    lblForecast1Low.Text = weather.Forecast.Days[0].Low.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //    lblForecast1High.Text = weather.Forecast.Days[0].High.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //    lblForecast1Conditions.Text = weather.Forecast.Days[0].Text;
        //    lblForecast1Code.Text = weather.Forecast.Days[0].Code.ToString();

        //    // πρόβλεψη δύο ημερών
        //    lblForecast2Date.Text = weather.Forecast.Days[1].Date.ToShortDateString();
        //    lblForecast2Low.Text = weather.Forecast.Days[1].Low.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //    lblForecast2High.Text = weather.Forecast.Days[1].High.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //    lblForecast2Conditions.Text = weather.Forecast.Days[1].Text;
        //    lblForecast2Code.Text = weather.Forecast.Days[1].Code.ToString();
        //    //lblCurrentTemperature.Text = weather.Condition.Temperature.ToString() + " " + weather.Units.GetTemperatureUnitAbbreviation();
        //}

        private void SetWeatherPicture(string weatherConditionsText)
        {
            //if (weatherConditionsText == "Clear") 
            //{
            //    pictureEditWeatherCondition.Image = new Bitmap(typeof(WeatherTracker.Resources.Image), "0cloud.png");
            //}
            //else if (weatherConditionsText == "Partly Cloudy") 
            //{
            //    pictureEditWeatherCondition.Image = new Bitmap(typeof(WeatherTracker.Resources.Image), "1cloud_norain.png");
            //}
            //else if (weatherConditionsText == "Light Rain")
            //{
            //    pictureEditWeatherCondition.Image = new Bitmap(typeof(WeatherTracker.Resources.Image), "4cloud_lightrain.png");
            //}
            //else if (weatherConditionsText == "Mostly Cloudy")
            //{
            //    pictureEditWeatherCondition.Image = new Bitmap(typeof(WeatherTracker.Resources.Image), "3cloud_norain.png");
            //}
        }
        
        #region Currently Commented
        //private void StartBackgroundTaskCurrentDay() {
        //    try {
        //        // execute the background task only if it's not already working
        //        if (!backgroundCurrentWorker.IsBusy) {
        //            this.UseWaitCursor = true; 
        //            this.backgroundCurrentWorker.RunWorkerAsync();
        //        }
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        //        throw;
        //    }
        //}

        //private Double ExtractTemperature() {
        //    if (this.lblCurrentTemperature.Text.Length == 0) {
        //        return int.MinValue;
        //    }
        //    else {
        //        // returning only the number portion ignoring the F
        //        return Double.Parse( lblCurrentTemperature.Text.Substring( 0, lblCurrentTemperature.Text.IndexOf( "'" ) ) );
        //    }
        //}

        //public void UpdateWeather() {
        //    try {
        //        tsmiRefresh.Enabled = false;
        //        tsmiOptions.Enabled = false;
        //        StartBackgroundTaskCurrentDay();
        //        tsmiRefresh.Enabled = true;
        //        tsmiOptions.Enabled = true;
        //    }
        //    catch (WebException) {
        //        MessageBox.Show( "Web Service currently unavailable.\n" +
        //            "Retry later using then Refresh weather Info menu.",
        //            "Web Exception" );
        //        tsmiRefresh.Enabled = true;
        //    }
        //}

        //private void CreateIcon() {

        //}
        #endregion

        private void tsmiExit_Click( object sender, EventArgs e )
        {
            ShutDown();
        }

        private void notifyWeather_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            Restore();
        }

        private void fMain_FormClosing( object sender, FormClosingEventArgs e )
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void tsmiOpen_Click( object sender, EventArgs e )
        {
            Restore();
            Focus();
        }

        private void fMain_Load( object sender, EventArgs e )
        {
            // Load splash screen first.
            Thread.Sleep(2000);
            splashForm.Close();

            // Load data.
            Weather weather = new Weather();

            weatherData = weather.GetCityWeather("Thessaloniki");

            UpdateUI();
        }

        private void tsmiAbout_Click( object sender, EventArgs e )
        {
            aboutForm.Show();
        }

        private void tsmiOptions_Click( object sender, EventArgs e )
        {
            //optionsForm.Show();
        }
     
    }
}