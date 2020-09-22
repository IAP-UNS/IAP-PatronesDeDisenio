using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TxtFileLoadDataBehaviour : ILoadDataBehaviour
{
    public string LoadData(string key)
    {
        string path = "Assets/Resources/test.txt";
        StreamReader reader = new StreamReader(path);
        reader.Close();
        return (reader.ReadToEnd());
    }
}
