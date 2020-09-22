using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardCommand : ICommand
{
    public void Execute(GameObject character)
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 1);
    }
}
