using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanelUI : MonoBehaviour
{
    /*private static ChangePanelUI _instance;
    public static ChangePanelUI Instance => _instance;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }*/

    public void ActivePanel(GameObject newActive)
    {
        newActive.SetActive(true);
    }

    public void DeactivePanel(GameObject newDeactive)
    {
        newDeactive.SetActive(false);
    }
}
