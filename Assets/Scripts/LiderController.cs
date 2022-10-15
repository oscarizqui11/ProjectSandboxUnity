using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct follower
{
    public GameObject followerObj;
    public Vector3 pos;
}

public class LiderController : MonoBehaviour
{
    public follower[] followers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GetTargetPos()
    {
        return followers[0].pos;
    }
}
