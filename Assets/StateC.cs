using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateC : BaseState
{
    public override void EnterState(StateManager context)
    {
        Debug.Log("You're in state C");
    }

    public override void UpdateState(StateManager context)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Switching to state A");
            context.SwitchState(context.stateA);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Switching to state B");
            context.SwitchState(context.stateB);
        }
    }
}
