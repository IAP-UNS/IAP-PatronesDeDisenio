using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInputHandler : MonoBehaviour
{
    public GameObject character;
    private ICommand commandA, commandS, commandD, commandW, commandSpace;

    // Start is called before the first frame update
    void Start()
    {
        commandSpace = new JumpCommand();
        commandA = new MoveLeftCommand();
        commandS = new MoveBackwardCommand();
        commandD = new MoveRightCommand();
        commandW = new MoveForwardCommand();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            commandA.Execute(character);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            commandD.Execute(character);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            commandW.Execute(character);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            commandS.Execute(character);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            commandSpace.Execute(character);
        }
    }
}
