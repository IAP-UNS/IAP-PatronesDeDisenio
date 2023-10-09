using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreator 
{
    private ICharacterFactory charFactory;

    public void SetCharacterFactory(ICharacterFactory characterFactory)
    {
        charFactory = characterFactory;
    }

    public void CreateNewCharacter()
    {
        charFactory.CreateNewCharacter();
    }
}
