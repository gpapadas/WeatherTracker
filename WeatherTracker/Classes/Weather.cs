using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;
using System.Net;
using Newtonsoft.Json;

namespace WeatherTracker.Classes
{
    public class Weather
    {
        private const string apiKey = Api.API_KEY; // Your API key here
        private const string openWeatherMapUrl = "https://api.openweathermap.org/data/2.5/weather";

        public Weather() { }

        public RootObject GetCityWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = $"{openWeatherMapUrl}?q={city}&appid={apiKey}&units=metric";

                var json = web.DownloadString(url);

                var data = JsonConvert.DeserializeObject<RootObject>(json);

                if (data.Cod == 200)
                {
                    return data;
                }
                else
                {
                    throw new Exception("Status code error!");
                }
            }
        }

        /*
        public void ConvertToMetric()
        {
            // c = (f-32)/1.8
            Condition.Temperature = Convert.ToInt32((Condition.Temperature - 32) / 1.8);
            // km = mi * 1.609344
            Atmosphere.Visibility = Convert.ToDecimal(Atmosphere.Visibility * (decimal)1.61);
            // mb = psi * 68.9475729
            Atmosphere.Pressure = Convert.ToDouble(Atmosphere.Pressure * (double)68.9475729);

            Wind.Chill = Convert.ToInt32((Wind.Chill - 32) / 1.8);
            Wind.Speed = Convert.ToInt32(Wind.Speed * 1.609344);

            foreach (ForecastDay fd in Forecast.Days)
            {
                fd.Low = Convert.ToInt32((fd.Low - 32) / 1.8);
                fd.High = Convert.ToInt32((fd.High - 32) / 1.8);
            }

            Units.Temperature = TemperatureUnits.Celcius;
            Units.Distance = DistanceUnits.Kilometeres;
            Units.Pressure = PressureUnits.Millibars;
            Units.Speed = SpeedUnits.KilometersPerHour;
        }

        public void ConvertToStandard()
        {
            // (f+32)*1.8
            Condition.Temperature = Convert.ToInt32((Condition.Temperature + 32) * 1.8);
            // km * 0.621371192 = mi
            Atmosphere.Visibility = Convert.ToDecimal(Atmosphere.Visibility * (decimal)0.62);
            // psi = mb * 0.0145037738
            Atmosphere.Pressure = Convert.ToDouble(Atmosphere.Pressure * (double)0.0145037738);

            Wind.Chill = Convert.ToInt32((Wind.Chill + 32) * 1.8);
            Wind.Speed = Convert.ToInt32(Wind.Speed * 0.621371192);

            foreach (ForecastDay fd in Forecast.Days)
            {
                fd.Low = Convert.ToInt32((fd.Low + 32) * 1.8);
                fd.High = Convert.ToInt32((fd.High + 32) * 1.8);
            }

            Units.Temperature = TemperatureUnits.Fahrenheit;
            Units.Distance = DistanceUnits.Miles;
            Units.Pressure = PressureUnits.PoundsPerSquareInch;
            Units.Speed = SpeedUnits.MilesPerHour;
        }
        */

        ///// <summary>
        ///// Custom date/time parsing function
        ///// </summary>
        ///// <param name="s">Date/time string in RFC822 Section 5 format</param>
        ///// <returns>DateTime object containing specified date</returns>
        //private DateTime ParseDateTime( string s ) {
        //    try {
        //        // vars to hold the date time parameters
        //        int month, day, year, hour, minute;

        //        // break the date/time string into parts using a space as the delimiter
        //        string[] arr = s.Split( ' ' );
        //        // break the time part of the date/time string into hours and minutes
        //        string[] arrTime = arr[4].Split( ':' );

        //        // temporary DateTime object
        //        DateTime dt;

        //        // read the date/time from the array
        //        day = Convert.ToInt32( arr[1] );
        //        year = Convert.ToInt32( arr[3] );
        //        hour = Convert.ToInt32( arrTime[0] );
        //        minute = Convert.ToInt32( arrTime[1] );

        //        // Convert 12-hour to 24-hour time
        //        if ( arr[5].ToLower() == "pm" ) {
        //            hour = hour + 12;
        //        }

        //        // Convert short month name to month number, 0 if error
        //        switch ( arr[2] ) {
        //            case "Jan":
        //            month = 1;
        //            break;
        //            case "Feb":
        //            month = 2;
        //            break;
        //            case "Mar":
        //            month = 3;
        //            break;
        //            case "Apr":
        //            month = 4;
        //            break;
        //            case "May":
        //            month = 5;
        //            break;
        //            case "Jun":
        //            month = 6;
        //            break;
        //            case "Jul":
        //            month = 7;
        //            break;
        //            case "Aug":
        //            month = 8;
        //            break;
        //            case "Sep":
        //            month = 9;
        //            break;
        //            case "Oct":
        //            month = 10;
        //            break;
        //            case "Nov":
        //            month = 11;
        //            break;
        //            case "Dec":
        //            month = 12;
        //            break;
        //            default:
        //            month = 0;
        //            break;
        //        }

        //        // Create DateTime object
        //        dt = new DateTime( year, month, day, hour, minute, 0 );
        //        // pass the DateTime object back to the caller
        //        return dt;
        //    }
        //    catch(Exception ex) {
        //         throw ex;   
        //    }
        //}
    }
}