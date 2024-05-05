using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateA : BaseState
{
    public override void EnterState(StateManager context)
    {
        Debug.Log("You're in state A");
    }

    public override void UpdateState(StateManager context)
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Switching to state B");
            context.SwitchState(context.stateB);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Switching to state C");
            context.SwitchState(context.stateC);
        }
    }
}
