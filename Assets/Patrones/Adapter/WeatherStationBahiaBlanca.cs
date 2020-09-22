using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeatherStationBahiaBlanca : MonoBehaviour
{
    public Text temperatureLabel;

    private IWeatherService weatherService;

    private void Start()
    {
        //weatherService = new GoogleWeatherService();
        //weatherService = new FullnessWeatherService();
        weatherService = new QuanticWeatherServiceAdapter();
    }

    public void ShowTemperature()
    {
        int temperature=weatherService.GetTemperature("Bahía Blanca");
        temperatureLabel.text = temperature+"";
    }

}
