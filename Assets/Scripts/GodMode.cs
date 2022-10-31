using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GodMode : MonoBehaviour
{
    private LiderController _liderPlayer;
    
    public float sprintVelocity;
    private float normalVelocity;

    public GameObject followerInstance;

    private bool debugMode;
    public GameObject debugUI;

    // Start is called before the first frame update
    void Start()
    {
        _liderPlayer = GetComponent<LiderController>();
        debugMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (debugMode)
        {

            if (Input.GetKeyDown(KeyCode.I))
            {
                ToggleInvincible();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GameManager.SetNextScene(2);
                SceneManager.LoadScene(0);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GameManager.SetNextScene(3);
                SceneManager.LoadScene(0);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                GameManager.SetNextScene(4);
                SceneManager.LoadScene(0);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                AddFollower();
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                RemoveFollower();
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                normalVelocity = _liderPlayer.GetComponent<MovementBehaviour>().velocity;
                _liderPlayer.GetComponent<MovementBehaviour>().velocity = sprintVelocity;
            }
            if (normalVelocity != 0 && Input.GetKeyUp(KeyCode.J))
            {
                _liderPlayer.GetComponent<MovementBehaviour>().velocity = normalVelocity;
            }
        }

        if(Input.GetKeyDown(KeyCode.F8))
        {
            ToggleDebugMode();
        }
    }

    private void ToggleDebugMode()
    {
        debugMode = !debugMode;
        debugUI.SetActive(debugMode);
    }

    private void ToggleInvincible()
    {
        Physics.IgnoreLayerCollision(6, 8, !Physics.GetIgnoreLayerCollision(6, 8));
        Physics.IgnoreLayerCollision(6, 9, !Physics.GetIgnoreLayerCollision(6, 9));
    }

    private void AddFollower()
    {
        for(int i = 0; i < _liderPlayer.followers.Length; i++)
        {
            if(_liderPlayer.followers[i].followerObj == null)
            {
                GameObject newFollower = Instantiate(followerInstance, _liderPlayer.transform.position + _liderPlayer.followers[i].pos, Quaternion.identity);
                newFollower.GetComponent<FollowerBehaviour>().StartFollowing(_liderPlayer);
                break;
            }
        }
    }

    private void RemoveFollower()
    {
        for (int i = _liderPlayer.followers.Length - 1; i >= 0; i--)
        {
            if (_liderPlayer.followers[i].followerObj != null)
            {
                _liderPlayer.followers[i].followerObj.GetComponent<HealthBehaviour>().Hurt(99);
                break;
            }
        }
    }

}
