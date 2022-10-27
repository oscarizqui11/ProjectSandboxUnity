using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLevel : MonoBehaviour
{
    public int oneStarMin;
    public int twoStarsMin;
    public int threeStarsMin;

    private int levelPunctuation;

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
            Debug.Log("Seguidores: " + numFollowers);

            if(numFollowers < oneStarMin)
            {
                Debug.Log("YOU LOST!");
                levelPunctuation = 0;
            }
            else if(numFollowers < twoStarsMin)
            {
                Debug.Log("YOU WIN 1 STAR!");
                levelPunctuation = 1;
            }
            else if(numFollowers < threeStarsMin)
            {
                Debug.Log("YOU WIN 2 STARS!!");
                levelPunctuation = 2;
            }
            else
            {
                Debug.Log("YOU WIN 3 STARS!!!");
                levelPunctuation = 3;
            }
        }
    }

    public int GetLevelPunctuation()
    {
        return levelPunctuation;
    }
}
