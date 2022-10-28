using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public string musicName;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.Play(musicName, true);
    }
}
