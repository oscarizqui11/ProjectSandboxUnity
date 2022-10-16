using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _anim;
    private MovementBehaviour _mov;

    private enum State
    {
        IDLE,
        WALKING,
        RUNNING
    }

    private State state;

    // Start is called before the first frame update
    void Start()
    {
        state = State.RUNNING;
        _anim = GetComponentInChildren<Animator>();
        _mov = GetComponent<MovementBehaviour>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        switch (state)
        {
            case State.IDLE:

                _anim.SetInteger("State", 0);

                if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
                {
                    state = State.RUNNING;
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    state = State.WALKING;
                }

                break;

            case State.WALKING:

                _anim.SetInteger("State", 1);
                PlayerMovement();

                if(!Input.GetKey(KeyCode.W))
                {
                    state = State.IDLE;
                }

                else if (Input.GetKey(KeyCode.LeftShift))
                {
                    state = State.RUNNING;
                }

                break;

            case State.RUNNING:

                _anim.SetInteger("State", 2);
                PlayerMovement();

                /*if (!Input.GetKey(KeyCode.LeftShift))
                {
                    state = State.WALKING;
                }*/

                break;

            default:
                state = State.IDLE;
                break;
        }        
    }

    private void PlayerMovement()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _mov.MoveTowards(transform.right + transform.forward);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _mov.MoveTowards(-transform.right + transform.forward);
        }
        else
        {
            _mov.MoveTowards(transform.forward);
        }
    }
}
