using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerBehaviour : MonoBehaviour
{
    private MovementBehaviour _mb;
    private Animator _anim;

    private bool isFollowing;
    private Vector3 targetPos;
    private GameObject targetLider;

    // Start is called before the first frame update
    void Start()
    {
        _mb = GetComponent<MovementBehaviour>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollowing)
        {
            if(transform.position.z <= targetLider.transform.position.z - targetPos.z)
            {
                _mb.MoveForward(false);                
            }

            if (transform.position.x < targetLider.transform.position.x + targetPos.x)
            {
                _mb.MoveRight();
            }
            else if (transform.position.x > targetLider.transform.position.x + targetPos.x)
            {
                _mb.MoveLeft();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isFollowing = true;
        transform.forward = other.transform.forward;

        targetPos = other.GetComponent<LiderController>().GetTargetPos();
        targetLider = other.gameObject;

        _anim.SetInteger("State", 2);

        Debug.Log(targetPos);
    }
}
