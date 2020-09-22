using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Alien();
    }

    
}
