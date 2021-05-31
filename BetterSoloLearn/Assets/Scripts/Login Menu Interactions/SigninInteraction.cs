using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigninInteraction : MonoBehaviour
{
    //This is the diffrent views accsessable from this UI
    [SerializeField] GameObject SigninUI;
    [SerializeField] GameObject LoginUI;
    [SerializeField] GameObject MainUI;

    //This is the btns
    [SerializeField] GameObject ConfirmBtn;
    [SerializeField] GameObject RerturnBtn;

    //This is the inputfields
    [SerializeField] GameObject UsernameInput;
    [SerializeField] GameObject EmailInput;
    [SerializeField] GameObject PasswordInput;

    //This is the ErrorMesssage
    [SerializeField] GameObject ErrorMessage;

    public void ConfirmAcc()
    {
        //Write code that confirms if an account with the same Email exists
        //If so display ErrorMessage
    }

    /// <summary>
    /// Displays error message
    /// </summary>
    private void DisplayErrorMessage()
    {
        ErrorMessage.SetActive(true);
    }

    public void LoginReturn()
    {
        SigninUI.SetActive(false);
        LoginUI.SetActive(true);
    }
}