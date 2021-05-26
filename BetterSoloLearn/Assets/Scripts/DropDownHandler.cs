using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{
    public static DropDownHandler instance;

    private void Awake()
    {
        instance = this;
    }

    void HandleInputData(int val)
    {
        switch (val)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
    }
}
