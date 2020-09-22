using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMemoryLoadDataBehaviour : ILoadDataBehaviour
{
    public string LoadData(string key)
    {
        return PlayerPrefs.GetString(key);
    }
}
