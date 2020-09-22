using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeatherService 
{
    int GetTemperature(string cityName);
}
