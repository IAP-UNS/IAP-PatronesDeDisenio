using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManagerFactoryMethod : MonoBehaviour
{
    private CharacterCreator characterCreator;

    // Start is called before the first frame update
    void Start()
    {
        characterCreator = new CharacterCreator();
        characterCreator.SetCharacterFactory(new RandomCharacterFactory());
        
        //llama a la función CreateNewCharacter cada 1 segundo.
        InvokeRepeating("CreateNewCharacter", 0, 1f);
    }

    void CreateNewCharacter()
    {
        characterCreator.CreateNewCharacter();
    }

    public void ActivateRandomCharactersFactory()
    {
        characterCreator.SetCharacterFactory(new RandomCharacterFactory());
    }

    public void ActivateAdultCharactersFactory()
    {
        characterCreator.SetCharacterFactory(new AdultsCharacterFactory());
    }

    public void ActivateKidCharactersFactory()
    {
        characterCreator.SetCharacterFactory(new KidCharacterFactory());
    }

    public void ActivateNonHumanCharactersFactory()
    {
        characterCreator.SetCharacterFactory(new NonHumanCharacterFactory());
    }
}
