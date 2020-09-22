using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartmanFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Cartman();
    }
}
