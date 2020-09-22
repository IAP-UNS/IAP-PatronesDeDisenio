using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultsCharacterFactory : ICharacterFactory
{
    private List<ICharacterFactory> characterFactories;

    public AdultsCharacterFactory()
    {
        characterFactories = new List<ICharacterFactory>();
        characterFactories.Add(new BarbradyFactory());
        characterFactories.Add(new ChefFactory());
        characterFactories.Add(new JimboFactory());
    }

    public Character CreateNewCharacter()
    {
        return characterFactories[Random.Range(0, characterFactories.Count)].CreateNewCharacter();
    }


}
