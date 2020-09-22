using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISmartwatchState 
{
    void OnHomeButtonPressed(SWControllerWithState sw);
    void OnTouchButtonPressed(SWControllerWithState sw);
    void OnLeftButtonPressed(SWControllerWithState sw);
    void OnRightButtonPressed(SWControllerWithState sw);
    string GetTitle();
    Sprite GetIconImage();
}
