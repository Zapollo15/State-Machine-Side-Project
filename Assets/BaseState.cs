using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState(StateManager context);
    public abstract void UpdateState(StateManager context);
}
