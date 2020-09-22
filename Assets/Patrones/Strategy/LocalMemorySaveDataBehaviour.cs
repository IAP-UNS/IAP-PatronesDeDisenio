using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMemorySaveDataBehaviour : ISaveDataBehaviour
{
    public void SaveData(string key, string data)
    {
        PlayerPrefs.SetString(key, data);
        PlayerPrefs.Save();
    }

}
