using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    BaseState currentState;
    public StateA stateA = new StateA();
    public StateB stateB = new StateB();
    public StateC stateC = new StateC();

    // Start is called before the first frame update
    public void Start()
    {
        currentState = stateA;
        currentState.EnterState(this);
    }

    public void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
