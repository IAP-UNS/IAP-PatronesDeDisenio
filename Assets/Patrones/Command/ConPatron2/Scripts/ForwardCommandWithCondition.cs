using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardCommandWithCondition : ICommandWithCondition
{
    public void Execute(GameObject character)
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 1);
    }

    public bool HasToExecute()
    {
        return Input.GetKey(KeyCode.W);
    }
}
