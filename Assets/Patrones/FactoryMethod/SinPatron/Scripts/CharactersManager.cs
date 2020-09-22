using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public void CreateRandomCharacter()
    {
        int r = Random.Range(0, 9);
        Character newCharacter;
        if (r == 0) newCharacter = new Alien();
        else if (r == 1) newCharacter = new Barbrady();
        else if (r == 2) newCharacter = new Cartman();
        else if (r == 3) newCharacter = new Chef();
        else if (r == 4) newCharacter = new Jimbo();
        else if (r == 5) newCharacter = new Kenny();
        else if (r == 6) newCharacter = new Kyle();
        else if (r == 7) newCharacter = new Stan();
        else if (r == 8) newCharacter = new Wendy();
    }

    public void CreateAdultCharacter()
    {
        int r = Random.Range(0, 3);
        Character newCharacter;
        if (r == 0) newCharacter = new Barbrady();
        else if (r == 1) newCharacter = new Chef();
        else if (r == 2) newCharacter = new Jimbo();
    }

    public void CreateKidCharacter()
    {
        int r = Random.Range(0, 5);
        Character newCharacter;
        if (r == 0) newCharacter = new Cartman();
        else if (r == 1) newCharacter = new Kenny();
        else if (r == 2) newCharacter = new Kyle();
        else if (r == 3) newCharacter = new Stan();
        else if (r == 4) newCharacter = new Wendy();
    }

    public void CreateNonHumanCharacter()
    {
        Character newCharacter = new Alien();
    }
}
