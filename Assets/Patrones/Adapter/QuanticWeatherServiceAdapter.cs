using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuanticWeatherServiceAdapter : IWeatherService
{
    public int GetTemperature(string cityName)
    {
        int zipCode = ConvertCityNameToZipCode(cityName);
        int temperature = new IAWeatherService().GetAccurateTemperature(zipCode);
        return temperature;
    }

    //Convierte el nombre de la ciudad a un código postal, por ejemplo con
    //un servicio web
    //datos de una base de datos
    //datos de algún archivo
    //etc
    int ConvertCityNameToZipCode(string cityName)
    {
        return 8000;
    }

}
