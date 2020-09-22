using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManagerFactoryMethod : MonoBehaviour
{
    private ICharacterFactory charFactory;

    // Start is called before the first frame update
    void Start()
    {
        charFactory = new RandomCharacterFactory();
        //llama a la función CreateNewCharacter cada 1 segundo.
        InvokeRepeating("CreateNewCharacter", 0, 0.1f);
    }

    void CreateNewCharacter()
    {
        charFactory.CreateNewCharacter();
    }

    public void ActivateRandomCharactersFactory()
    {
        charFactory = new RandomCharacterFactory();
    }

    public void ActivateAdultCharactersFactory()
    {
        charFactory = new AdultsCharacterFactory();
    }

    public void ActivateKidCharactersFactory()
    {
        charFactory = new KidCharacterFactory();
    }

    public void ActivateNonHumanCharactersFactory()
    {
        charFactory = new NonHumanCharacterFactory();
    }
}
