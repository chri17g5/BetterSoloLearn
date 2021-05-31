using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavBtnScript : MonoBehaviour
{
    public static NavBtnScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }
    void EnablePanel()
    {
        
    }
}
