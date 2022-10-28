using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLevel : MonoBehaviour
{
    public int oneStarMin;
    public int twoStarsMin;
    public int threeStarsMin;

    private int levelPunctuation;

    public IntEvent onEndOfLevel;

    // Start is called before the first frame update
    void Start()
    {
        levelPunctuation = -1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out LiderController player))
        {
            int numFollowers = 0;

            for(int i = 0; i < player.followers.Length; i++)
            {
                if(player.followers[i].followerObj != null)
                {
                    numFollowers++;
                }
            }

            if(numFollowers < oneStarMin)
            {
                levelPunctuation = 0;
            }
            else if(numFollowers < twoStarsMin)
            {
                levelPunctuation = 1;
            }
            else if(numFollowers < threeStarsMin)
            {
                levelPunctuation = 2;
            }
            else
            {
                levelPunctuation = 3;
            }

            onEndOfLevel.Invoke(levelPunctuation);
        }
    }

    public int GetLevelPunctuation()
    {
        return levelPunctuation;
    }
}
