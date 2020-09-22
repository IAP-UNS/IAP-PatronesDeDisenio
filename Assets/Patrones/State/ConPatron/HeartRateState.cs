using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRateState : ISmartwatchState
{
    public void OnHomeButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HomeState());
    }

    public void OnLeftButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new HomeState());
    }

    public void OnRightButtonPressed(SWControllerWithState sw)
    {
        sw.ChangeState(new RunningState());
    }

    public void OnTouchButtonPressed(SWControllerWithState sw)
    {
        Debug.Log("Comenzar a monitorear el ritmo cardíaco");
    }

    public string GetTitle()
    {
        return "Heart Rate";
    }

    public Sprite GetIconImage()
    {
        return ImageProvider.instance.HeartRateIcon;
    }
}
