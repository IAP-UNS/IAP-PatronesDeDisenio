using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SWControllerWithState : MonoBehaviour
{
    private ISmartwatchState currentState;
    public Text titleLabel;
    public Image currentIcon;

    void Start()
    {
        ChangeState(new HomeState());
    }

    void UpdateTextLabel()
    {
        titleLabel.text = currentState.GetTitle();
    }

    void UpdateIcon()
    {
        currentIcon.sprite = currentState.GetIconImage();
    }

    public void ChangeState(ISmartwatchState newState)
    {
        currentState = newState;
        UpdateTextLabel();
        UpdateIcon();
    }

    public void OnHomeButtonPressed()
    {
        currentState.OnHomeButtonPressed(this);
    }

    public void OnTouchButtonPressed()
    {
        currentState.OnTouchButtonPressed(this);
    }

    public void OnLeftButtonPressed()
    {
        currentState.OnLeftButtonPressed(this);
    }

    public void OnRightButtonPressed()
    {
        currentState.OnRightButtonPressed(this);
    }


}
