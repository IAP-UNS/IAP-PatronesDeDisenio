using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidCharacterFactory : ICharacterFactory
{
    private List<ICharacterFactory> characterFactories;

    public KidCharacterFactory()
    {
        characterFactories = new List<ICharacterFactory>();
        characterFactories.Add(new KennyFactory());
        characterFactories.Add(new KyleFactory());
        characterFactories.Add(new StanFactory());
        characterFactories.Add(new WendyFactory());
        characterFactories.Add(new CartmanFactory());
    }

    public Character CreateNewCharacter()
    {
        return characterFactories[Random.Range(0, characterFactories.Count)].CreateNewCharacter();
    }


}
