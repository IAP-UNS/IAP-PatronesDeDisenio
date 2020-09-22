using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendyFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Wendy();
    }
}
