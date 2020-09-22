using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataStorageManager : MonoBehaviour
{
    public InputField inputField;
    public Text loadedTextLabel;

    private ISaveDataBehaviour saveDataBehaviour;
    private ILoadDataBehaviour loadDataBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        //se setea alguno inicialmente, puede setearse desde afuera
        saveDataBehaviour = new LocalMemorySaveDataBehaviour();
        loadDataBehaviour = new LocalMemoryLoadDataBehaviour();
    }

    public void SaveData()
    {
        string data = inputField.text;
        saveDataBehaviour.SaveData("testData",data);
        Debug.Log("Información almacenada.");
    }

    public void LoadData()
    {
        string data = loadDataBehaviour.LoadData("testData");
        loadedTextLabel.text = data;
        Debug.Log("Información cargada.");
    }
}
