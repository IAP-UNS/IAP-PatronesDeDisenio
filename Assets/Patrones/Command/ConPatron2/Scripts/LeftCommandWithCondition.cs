using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommandWithCondition : ICommandWithCondition
{
    public void Execute(GameObject character)
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(-1, 0, 0);
    }

    public bool HasToExecute()
    {
        return Input.GetKey(KeyCode.A);
    }
}
