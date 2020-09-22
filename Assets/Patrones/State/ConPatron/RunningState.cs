using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningState : ISmartwatchState
{
    public void OnHomeButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HomeState());
    }

    public void OnLeftButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HeartRateState());
    }

    public void OnRightButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new ConfigurationState());
    }

    public void OnTouchButtonPressed(SWControllerWithState sw)
    {
        Debug.Log("Comenzar a contar pasos y calorías");
    }

    public string GetTitle()
    {
        return "Running";
    }

    public Sprite GetIconImage()
    {
        return ImageProvider.instance.RunningIcon;
    }
}
