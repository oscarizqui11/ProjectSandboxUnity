using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float speed;
    public float runSpeed;

    // Start is called before the first frame update

    public void MoveForward(bool running)
    {
        if(!running)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.forward * runSpeed * Time.deltaTime;
        }
    }

    public void MoveLeft()
    {
        transform.position -= transform.right * runSpeed * Time.deltaTime;
    }

    public void MoveRight()
    {
        transform.position += transform.right * runSpeed * Time.deltaTime;
    }
}
