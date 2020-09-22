using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TxtFileSaveDataBehaviour : ISaveDataBehaviour
{
    public void SaveData(string key, string data)
    {
        string path = "Assets/Resources/test.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(data);
        writer.Close();
    }

   
}
