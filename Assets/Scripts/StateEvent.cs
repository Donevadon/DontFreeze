using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateEvent : System.EventArgs
{
    public float State{get;}

    public StateEvent(float state)
    {
        State = state;
    }
}
