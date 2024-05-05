using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateB : BaseState
{
    public override void EnterState(StateManager context)
    {
        Debug.Log("You're in state B");
    }

    public override void UpdateState(StateManager context)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Switching to state A");
            context.SwitchState(context.stateA);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Switching to state C");
            context.SwitchState(context.stateC);
        }
    }
}
