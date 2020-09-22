using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimboFactory: ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Jimbo();
    }
}
