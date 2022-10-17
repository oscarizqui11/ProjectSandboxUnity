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

    public Vector3 GetTargetPos(GameObject followerAsking)
    {
        Vector3 ret = Vector3.zero;

        for (int i = 0; i < followers.Length; i++)
        {
            if (followers[i].followerObj == followerAsking)
            {
                ret = followers[i].pos;
                break;
            }
        }

        return ret;
    }

    public void SetFollower(GameObject newFollower)
    {
        for(int i = 0; i < followers.Length; i++)
        {
            if(followers[i].followerObj == null)
            {
                if (followers[i].followerObj != newFollower)
                {
                    followers[i].followerObj = newFollower;
                }
                break;
            }
        }
    }
}
