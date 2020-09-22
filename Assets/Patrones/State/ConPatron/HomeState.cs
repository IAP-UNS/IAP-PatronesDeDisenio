using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeState : ISmartwatchState
{
    public void OnHomeButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HomeState());
    }

    public void OnLeftButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new ConfigurationState());
    }

    public void OnRightButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HeartRateState());
    }

    public void OnTouchButtonPressed(SWControllerWithState sw)
    {
        Debug.Log("Estoy en Home, no debo hacer nada por ahora.");
    }

    public string GetTitle()
    {
        return "Home";
    }

    public Sprite GetIconImage()
    {
        return ImageProvider.instance.HomeIcon;
    }
}
