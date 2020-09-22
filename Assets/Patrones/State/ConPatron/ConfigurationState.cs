using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationState : ISmartwatchState
{
    public void OnHomeButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HomeState());
    }

    public void OnLeftButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new RunningState());
    }

    public void OnRightButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HomeState());
    }

    public void OnTouchButtonPressed(SWControllerWithState sw)
    {
        Debug.Log("Enviar a otro menú especial con configuraciones");
    }

    public string GetTitle()
    {
        return "Configuration";
    }

    public Sprite GetIconImage()
    {
        return ImageProvider.instance.ConfigurationIcon;
    }
}