using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class StateMachine : MonoBehaviour
{
    private State currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = GetComponent<Startup>();
        currentState.OnEnter();
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Tick();
    }


    public void ChangeState (State NewState)
    {
        currentState.OnExit();
        currentState = NewState;
        currentState.OnEnter();

    }
}
