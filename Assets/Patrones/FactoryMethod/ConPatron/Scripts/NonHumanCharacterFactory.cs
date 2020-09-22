using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonHumanCharacterFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Alien();
    }

    
}
