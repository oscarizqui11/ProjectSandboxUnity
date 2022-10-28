using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFXOnDie : MonoBehaviour
{
    public string sfxName;

    public void PlaySoundFX()
    {
        SoundManager.Instance.Play(sfxName, false);
    }

}
