using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommandWithCondition
{
    bool HasToExecute();
    void Execute(GameObject character);
}
