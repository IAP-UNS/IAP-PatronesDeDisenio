using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommandWithCondition : ICommandWithCondition
{
    public void Execute(GameObject character)
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(0, 1, 0);
    }

    public bool HasToExecute()
    {
        return Input.GetKey(KeyCode.Space);
    }
}
