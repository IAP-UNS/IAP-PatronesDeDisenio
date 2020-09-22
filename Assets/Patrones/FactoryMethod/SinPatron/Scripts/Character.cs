using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character 
{
    private GameObject myVisual;

    public Character(string modelName)
    {
        Vector3 randomPosition = new Vector3(Random.Range(-12, 12), 0, Random.Range(-7, 7));
        Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        myVisual = MonoBehaviour.Instantiate(Resources.Load("Characters/"+modelName), randomPosition, randomRotation) as GameObject;
    }
}
