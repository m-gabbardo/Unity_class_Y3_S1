using UnityEngine;

public partial class State : MonoBehaviour
{
    public virtual void OnEnter()
    {

    }
    public virtual void Tick()
    {

    }
    public virtual void OnExit()
    {

    }
}

public class Startup : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<StateMachine>().ChangeState(GetComponent<Menu>());
        }
    }
    public override void OnExit()
    {

    }
}

public class Menu : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {

    }
    public override void OnExit()
    {

    }
}

public class Loading : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {

    }
    public override void OnExit()
    {

    }
}

public class InGame : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {

    }
    public override void OnExit()
    {

    }
}

public class GameOver : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {

    }
    public override void OnExit()
    {

    }
}

public class Pause : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {

    }
    public override void OnExit()
    {

    }
}

public class Shutdown : State
{
    public override void OnEnter()
    {

    }
    public override void Tick()
    {

    }
    public override void OnExit()
    {

    }
}