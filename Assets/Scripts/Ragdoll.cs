using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private Rigidbody[] rigidbodies;

    [SerializeField] bool ragdoll;

    private void Start()
    {
        rigidbodies= GetComponentsInChildren<Rigidbody>();
        SetEnabled(false);
    }

    public void SetEnabled(bool enabled)
    {
        bool isKinematic = !enabled;
        foreach(Rigidbody rb in rigidbodies) 
        {
            if(rb.tag != "Body")
                rb.isKinematic = isKinematic;
            else
                rb.GetComponent<CapsuleCollider>().enabled= !enabled;
        }

        animator.enabled= !enabled;
    }

    private void Update()
    {
        if(ragdoll)
        {
            SetEnabled(true);
            ragdoll= false;
        }
    }
}
