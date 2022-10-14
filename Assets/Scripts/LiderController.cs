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
    public const int NUM_FOLLOWERS = 9;

    public follower[] followers;

    // Start is called before the first frame update
    void Start()
    {
        followers = new follower[NUM_FOLLOWERS];

        followers[0].pos = new Vector3(0, 0, 0);

        Debug.Log(followers[0].pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
