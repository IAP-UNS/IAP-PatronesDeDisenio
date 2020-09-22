using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }else if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }else if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }


    void MoveLeft()
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(-1, 0, 0);
    }

    void MoveRight()
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(1, 0, 0);
    }

    void MoveForward()
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 1);
    }

    void MoveBackward()
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(0,0, -1);
    }

    void Jump()
    {
        character.GetComponent<Rigidbody>().velocity += new Vector3(0, 1, 0);
    }
}
