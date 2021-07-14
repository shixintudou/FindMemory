using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseActor: MonoBehaviour
{
    public enum State
    {
        Idle,Run,Jump,Attack,Behurt,Dead
    }

    public State state;
    // Start is called before the first frame update
    void Start()
    {
        state = State.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Idle:
                StateIdle();
                break;
            case State.Jump:
                StateJump();
                break;
            case State.Run:
                StateRun();
                break;
            case State.Attack:
                StateAttack();
                break;
            case State.Behurt:
                StateBehurt();
                break;
            case State.Dead:
                StateDead();
                break;
        }
    }
    public virtual void StateIdle()
    {

    }
    public virtual void StateJump()
    {

    }
    public virtual void StateRun()
    {

    }
    public virtual void StateAttack()
    {

    }
    public virtual void StateBehurt()
    {

    }
    public virtual void StateDead()
    {

    }



    public virtual void ChangeToIdle()
    {
        state = State.Idle;
    }
    public virtual void ChangeToRun()
    {
        state = State.Run;
    }
    public virtual void ChangeToJump()
    {
        state = State.Jump;
    }
    public virtual void ChangeToAttack()
    {
        state = State.Attack;
    }
    public virtual void ChangeToBehurt()
    {
        state = State.Behurt;
    }
    public virtual void ChangeToDead()
    {
        state = State.Dead;
    }
}
