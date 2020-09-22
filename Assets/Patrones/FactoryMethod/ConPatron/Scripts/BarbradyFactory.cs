using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbradyFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Barbrady();
    }
}
