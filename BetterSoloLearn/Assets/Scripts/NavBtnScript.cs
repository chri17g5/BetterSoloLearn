using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class NavBtnScript : MonoBehaviour
{
    public static NavBtnScript instance;

    //Assign GameObjects with variable names,
    //so that they can be called in the script later, whether active in Unity or not.
    GameObject AD;
    GameObject MD;
    GameObject LIUI;
    GameObject SIUI;
    GameObject NTLB;
    GameObject NTSB;
    private void Awake()
    {
        //Assign continued.
        LIUI = GameObject.FindWithTag("LogInUI");
        SIUI = GameObject.FindWithTag("SignInUI");
        AD = GameObject.FindWithTag("AuthDisplay");
        MD = GameObject.FindWithTag("MainDisplay");
    }
    private void Start()
    {
        //Deactivates AuthDisplay as it is not supposed to be active on startup.
        //At least not in this iteration of the app.
        AD.SetActive(false);
    }

    public void Navigate()
    {
        //Every time button/Navigate() is called, a new instance is declared,
        //making sure the specific code that runs is the correct one according to its tag.
        instance = this;

        //Logs both this.tag and instance.tag as they need to be the same
        //so that the if statement does not receive incorrect information.
        //Used this to notice a bug as instance.tag was assigned only once, on awake,
        //so no matter which button was pressed it ran only one cluster of code
        Debug.Log($"This tag is {this.tag} And instance tag is {instance.tag}");

        //Notifies that the Navigate() method actually runs when intended.
        Debug.Log("Running navigate script");
        if (instance.tag == "NavToLoginBtn")
        {
            //Debug.Logs to make sure that the correct things are happening in the correct order
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
            //Extra precaution to check whether it ran any of the two if statements.
            //The Signin button has the same else.
            Debug.Log("did not run Login button code");
        }
        if (instance.tag == "NavToSigninBtn")
        {
            if (instance.tag == "NavToLoginBtn")
            {
                //Checks to see if the instance tag (SOMEHOW, No idea how exactly) is truly "NavToSigninBtn"
                //Never actually ran, which was in itself instrumental in pointing my attention elsewhere,
                //to the real problem.(See Line 36)
                Debug.Log("Wr0ng wr0ng wr0ng!");

                //Note: I was losing my patience at this point. Hence the unprofessional Debug.Log.


                return;
            }
            Debug.Log("Button pressed is SignIn button");
            Debug.Log($"This tag is {this.tag} And instance tag is {instance.tag}");

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
