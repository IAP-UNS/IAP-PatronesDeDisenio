using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartwatchController : MonoBehaviour
{
    /** Current state of smartwatch
     * 0: Home
     * 1: Heart Rate Mode
     * 2: Running Mode
     * 3: Configuration Mode
     **/
    private int currentState;
    public Text titleLabel;
    public Image currentIcon;

    public Sprite[] stateIcons;

    // Start is called before the first frame update
    void Start()
    {
        currentState = 0;
        UpdateState();
    }

    void UpdateState()
    {
        UpdateTitle();
        UpdateIcon();
    }

    void UpdateTitle()
    {
        switch (currentState) { 
            case 0:
                titleLabel.text = "Home";
                break;
            case 1:
                titleLabel.text = "HeartRate";
                break;
            case 2:
                titleLabel.text = "Running";
                break;
            case 3:
                titleLabel.text = "Configuration";
                break;
        }
    }

    void UpdateIcon()
    {
        currentIcon.sprite = stateIcons[currentState];
    }

    public void OnHomeButtonPressed()
    {
        //no importa el estado en el que esté, vuelve al Home
        currentState = 0;
        UpdateState();
    }

    public void OnTouchButtonPressed()
    {
        switch (currentState)
        {
            case 0:
                //No hacer nada
                Debug.Log("Estoy en Home, no hago nada.");
                break;
            case 1:
                Debug.Log("Comenzar a monitorear el ritmo cardíaco");
                break;
            case 2:
                Debug.Log("Comenzar a contar pasos y calorías");
                break;
            case 3:
                Debug.Log("Enviar a otro menú especial con configuraciones");
                break;
        }
    }

    public void OnLeftButtonPressed()
    {
        if (currentState == 0)
        {
            currentState = 3;
        }
        else
        {
            currentState = (currentState - 1) % 4;
        }
        UpdateState();
    }

    public void OnRightButtonPressed()
    {
        currentState = (currentState + 1) % 4;
        UpdateState();
    }
}
