using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerWithCondition : MonoBehaviour
{
    public GameObject character;
    private List<ICommandWithCondition> commands;

    // Start is called before the first frame update
    void Start()
    {
        commands = new List<ICommandWithCondition>();
        commands.Add(new LeftCommandWithCondition());
        commands.Add(new RightCommandWithCondition());
        commands.Add(new ForwardCommandWithCondition());
        commands.Add(new BackwardCommandWithCondition());
        commands.Add(new JumpCommandWithCondition());
    }

    // Update is called once per frame
    void Update()
    {
        foreach(ICommandWithCondition c in commands)
        {
            if (c.HasToExecute())
            {
                c.Execute(character);
            }
        }
    }
}
