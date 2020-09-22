using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KennyFactory : ICharacterFactory
{
    public Character CreateNewCharacter()
    {
        return new Kenny();
    }
}
