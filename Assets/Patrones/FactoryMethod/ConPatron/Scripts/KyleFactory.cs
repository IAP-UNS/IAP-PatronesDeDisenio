using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Kyle();
    }
}
