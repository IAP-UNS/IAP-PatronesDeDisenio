using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    public void Execute(GameObject character)
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(1, 0, 0);
    }
}
