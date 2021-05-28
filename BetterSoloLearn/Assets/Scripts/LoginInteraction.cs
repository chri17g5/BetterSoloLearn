using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginInteraction : MonoBehaviour
{
    public static LoginInteraction instance;
    [SerializeField] GameObject LoginPanel;
    [SerializeField] GameObject SigninPanel;
    [SerializeField] GameObject MainPanel;

    private void OnEnable()
    {
        instance = this;
    }

    public void LogInCheck()
    {
        //Insert Code that checks with fireabase if the user exists
        //Teacher insists on using Regex keep that in mind
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
