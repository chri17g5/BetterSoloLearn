using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginInteraction : MonoBehaviour
{
    //These are the diffrent us displays
    [SerializeField] GameObject LoginPanel;
    [SerializeField] GameObject SigninPanel;
    [SerializeField] GameObject MainPanel;

    //These are the inputfield within the LoginUI
    [SerializeField] GameObject UsernameInput;
    [SerializeField] GameObject PasswordInput;

    //Error message
    [SerializeField] GameObject ErrorMessageDisplay;

    public void LogInCheck()
    {
        //Insert Code that checks with fireabase if the user exists
        //Teacher insists on using Regex keep that in mind
    }

    /// <summary>
    /// Displays error message
    /// </summary>
    private void DisplayErrorMessage()
    {
        ErrorMessageDisplay.SetActive(true);
    }

    /// <summary>
    /// Disables LoginPanel and enabels the SigninPanel
    /// </summary>
    public void ShowSignIn()
    {
        LoginPanel.SetActive(false);
        SigninPanel.SetActive(true);
    }

    /// <summary>
    /// Disables LoginPanel and enabels the MainPanel
    /// </summary>
    public void ContinueToMain()
    {
        LoginPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
}
