using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class NavBtnScript : MonoBehaviour
{
    public static NavBtnScript instance;
    GameObject AD;
    GameObject MD;
    GameObject LIUI;
    GameObject SIUI;
    GameObject NTLB;
    GameObject NTSB;
    private void Awake()
    {
        LIUI = GameObject.FindWithTag("LogInUI");
        SIUI = GameObject.FindWithTag("SignInUI");
        AD = GameObject.FindWithTag("AuthDisplay");
        MD = GameObject.FindWithTag("MainDisplay");
    }
    private void Start()
    {
        AD.SetActive(false);
    }

    public void Navigate()
    {
        instance = this;
        Debug.Log($"This tag is {this.tag}" + $" And instance tag is {instance.tag}");
        Debug.Log("Running navigate script");
        if (instance.tag == "NavToLoginBtn")
        {
            Debug.Log("Button pressed is Login button");

                AD.SetActive(true);
                Debug.Log("Activating AuthDisplay");
            
                SIUI.SetActive(false);
                Debug.Log("Deactivating SignInUI");

                LIUI.SetActive(true);
                Debug.Log("Activating LogInUI");
            

                MD.SetActive(false);
                Debug.Log("Deactivating MainDisplay");
            
        }
        else
        {
            Debug.Log("did not run Login button code");
        }
        if (instance.tag == "NavToSigninBtn")
        {
            if (instance.tag == "NavToLoginBtn")
            {
                Debug.Log("Wr0ng wr0ng wr0ng!");
                return;
            }
            Debug.Log("Button pressed is SignIn button");
            Debug.Log($"This tag is {this.tag}" + $" And instance tag is {instance.tag}");

            AD.SetActive(true);
             Debug.Log("Activating AuthDisplay");


             LIUI.SetActive(false);
             Debug.Log("Deactivating LogInUI");


             SIUI.SetActive(true);
             Debug.Log("Activating SignInUI");


             MD.SetActive(false);
             Debug.Log("Deactivating MainDisplay");

        }
        else
        {
            Debug.Log("Did not run Signin button code");
        }

    }
}
