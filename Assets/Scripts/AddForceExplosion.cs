using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddForceExplosion : MonoBehaviour
{
    [SerializeField] float explosionForce;
    [SerializeField] float upWardModifier;
    float radius;

    [SerializeField] string[] bodyTypesToAffect = new string[0];

    private void Start()
    {
        radius = GetComponent<SphereCollider>().radius;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(HasToApplyForceToBodyType(other.tag))
        {
            other.attachedRigidbody.AddExplosionForce(explosionForce, transform.position, radius, upWardModifier);
        }
    }

    bool HasToApplyForceToBodyType(string colliderBodyType)
    {
        bool ret = false;

        for(int i = 0; i < bodyTypesToAffect.Length; i++)
        {
            if (string.Equals(colliderBodyType, bodyTypesToAffect[i]))
            {
                ret = true;
            }
        }        

        return ret;
    }

}
