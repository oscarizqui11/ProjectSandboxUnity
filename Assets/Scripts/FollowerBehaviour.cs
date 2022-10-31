using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerBehaviour : MonoBehaviour
{
    public int pointsCost;

    private MovementBehaviour _mb;
    private Animator _anim;

    private bool isFollowing;
    private Vector3 targetPos;
    private GameObject targetLider;
    private Vector3 targetDir;

    // Start is called before the first frame update
    void Awake()
    {
        _mb = GetComponent<MovementBehaviour>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isFollowing)
        {
            
            if(transform.position.z <= targetLider.transform.position.z - targetPos.z)
            {
                targetDir = transform.forward;                

                if (Mathf.Abs(((targetLider.transform.position.x + targetPos.x) - transform.position.x)) > 0.1)
                {
                    if (transform.position.x < targetLider.transform.position.x + targetPos.x)
                    {
                        targetDir += transform.right;
                    }
                    else if (transform.position.x > targetLider.transform.position.x + targetPos.x)
                    {
                        targetDir -= transform.right;
                    }
                }

            _mb.MoveTowards(targetDir);
            
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isFollowing && other.TryGetComponent<ScoreBehaviour>(out ScoreBehaviour _otherScore))
        {
            if(_otherScore.scorePoints >= pointsCost)
            {
                _otherScore.SetScore(_otherScore.scorePoints - pointsCost);

                if (other.TryGetComponent<LiderController>(out LiderController _lider))
                {
                    StartFollowing(_lider);                    
                }
            }
        }
    }

    public void StartFollowing(LiderController newLider)
    {
        isFollowing = true;
        transform.forward = newLider.transform.forward;
        newLider.SetFollower(gameObject);
        targetPos = newLider.GetTargetPos(gameObject);

        targetLider = newLider.gameObject;

        _anim.SetInteger("State", 2);
    }
}
