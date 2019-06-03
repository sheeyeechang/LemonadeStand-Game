using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{   
    public class Weather
    {
        //member varibale

        public List<string> weather;
        public string currentWeather;
        public List<string> forecast;
        public string currentForecast;

        public List<int> temperature;
        public int currentTemperature;

        Random random;

        //member contructor
        public Weather()
        {
        weather = new List<string>() { "good", "fair", "bad" };
        forecast = new List<string>() {};

        temperature = new List<int>() { };

        random = new Random();
        }

        //member method

        //Today's temperature
        public int TemperatureConditions()
        {
            currentTemperature = random.Next(55, 99);
            return currentTemperature;

        }

        //Weather/Forecast
        //This week's forecast is 
        //Today's weather is 

        public void TypeOfWeatherConditions()
        {
            int i = random.Next(0, 3);
            currentWeather = weather[i];
        }
  

        public string WeekForecast(List<string> dayNames)
        {
            string weekWeatherConditions = "";
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                // weekWeatherConditions += "";
                TypeOfWeatherConditions();
                weekWeatherConditions += (" " + dayNames[i] + " = " + currentWeather + ",");
                // weekWeatherConditions = weekWeatherConditions + dayNames[i] + " " + currentWeather;
               
                // add the currentWeather onto weekWeatherConditions

            }
            return weekWeatherConditions;
        }

    }
}
