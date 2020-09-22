using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuanticWeatherService 
{
    int GetAccurateTemperature(int zipCode);
}
