using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StanFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Stan();
    }
}
