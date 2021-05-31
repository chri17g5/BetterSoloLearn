using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class NavBtnScript : MonoBehaviour
{
    public void Navigate()
    {
        Debug.Log(this.tag);
        Debug.Log("Running navigate script");
        if (this.tag == "NavToLoginBtn")
        {
            Debug.Log("Button pressed is Login button");
            if (GameObject.FindWithTag("AuthDisplay"))
            {
                GameObject.FindWithTag("AuthDisplay").SetActive(true);
                Debug.Log("Found AuthDisplay");
            }
            if (GameObject.FindWithTag("LogInUI"))
            {
                GameObject.FindWithTag("LogInUI").SetActive(true);
                Debug.Log("Found LogInUI");
            }
            if (GameObject.FindWithTag("SignInUI"))
            {
                GameObject.FindWithTag("SignInUI").SetActive(false);
                Debug.Log("Found SignInUI");
            }
            if (GameObject.FindWithTag("MainDisplay"))
            {
                GameObject.FindWithTag("MainDisplay").SetActive(false);
                Debug.Log("Found MainDisplay");
            }
        }
        else
        {
            Debug.Log("did not run Login button code");
        }
        if (this.tag == "NavToSigninBtn")
        {
            Debug.Log("Button pressed is Signin button");
            if (gameObject.tag == "AuthDisplay")
            {
                gameObject.SetActive(true);
            }
            if (gameObject.tag == "SignInUI")
            {
                gameObject.SetActive(true);
            }
            if (gameObject.tag == "LogInUI")
            {
                gameObject.SetActive(false);
            }
            if (gameObject.tag == "MainDisplay")
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.Log("Did not run Signin button code");
        }

    }
}
