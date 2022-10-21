using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Animator _anim;
    private MovementBehaviour _mov;

    private bool isMoving;

    private enum State
    {
        IDLE,
        FORWARD,
        LEFT,
        RIGHT
    }

    private State state;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponentInChildren<Animator>();
        _mov = GetComponent<MovementBehaviour>();
        isMoving = false;
        state = State.IDLE;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            GameManager.SetNextScene(1);
            SceneManager.LoadScene(0);
        }

        if(state == State.IDLE && Input.GetKey(KeyCode.Space))
        {
            isMoving = true;
            _anim.SetInteger("State", 2);
        }

        if (isMoving)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                state = State.RIGHT;
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                state = State.LEFT;
            }
            else
            {
                state = State.FORWARD;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMoving)
        {
            PlayerMovement();
        }    
    }

    private void PlayerMovement()
    {
        if (state == State.RIGHT)
        {
            _mov.MoveTowards(transform.right + transform.forward);
        }
        else if (state == State.LEFT)
        {
            _mov.MoveTowards(-transform.right + transform.forward);
        }
        else if (state == State.FORWARD)
        {
            _mov.MoveTowards(transform.forward);
        }
    }
}
