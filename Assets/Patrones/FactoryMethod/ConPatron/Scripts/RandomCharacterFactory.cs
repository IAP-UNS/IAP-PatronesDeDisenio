using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCharacterFactory : ICharacterFactory
{
    private List<ICharacterFactory> characterFactories;

    public RandomCharacterFactory()
    {
        characterFactories = new List<ICharacterFactory>();
        characterFactories.Add(new AlienFactory());
        characterFactories.Add(new BarbradyFactory());
        characterFactories.Add(new ChefFactory());
        characterFactories.Add(new JimboFactory());
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
