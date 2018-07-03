using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour {

    public InputField usernameInput;
    public InputField passwordInput;
    public InputField confPasswordInput;
    public InputField classInput;
    public InputField schoolInput;

    private string username; //captial Username
    private string password;
    private string confPassword;
    private string form;

    private bool emailValid = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (password != "" && confPassword != "")
            {
                RegisterButton();
            }
        }

        username = usernameInput.GetComponent<InputField>().text;
        password = passwordInput.GetComponent<InputField>().text;
        confPassword = confPasswordInput.GetComponent<InputField>().text;
    }
    public void RegisterButton()
    {
        bool validUN = false;
        bool validPW = false;

        #region UsernameCheck
        if (username != "")
        {
            if (!System.IO.File.Exists(@"C:\Making games\Praktijk Route\Tryater\Networking tries\Assets\scenes\database classes\Plugins" + username + ".txt"))
            {
                validUN = true;
            }
            else
            {
                Debug.LogWarning("Username Taken");
            }
        }
        else
        {
            Debug.LogWarning("Username field is empty");
        }
        #endregion
        #region passwordCheck
        if (password != "")
        {
            if (password.Length > 5)
            {
                validPW = true;
            }
            else
            {
                Debug.LogWarning("wachtwoord moet minimaal 6 karakters hebben");
            }
        }
        else
        {
            Debug.LogWarning("wachtwoord veld is leeg");
        }

        if(confPassword != "")
        {
            if (confPassword == password)
            {
                validPW = true;
            }
            else
            {
                Debug.LogWarning("Wachtwoorden komen niet overeen");
            }
        }
        else
        {
            Debug.LogWarning("Bevestig wachtwoord veld is leeg ");
        }

#endregion

        if (validUN == true && validPW == true)
        {
            form = (username+ Environment.NewLine +  password);
            System.IO.File.WriteAllText(@"C:\Making games\Praktijk Route\Tryater\Networking tries\Assets\scenes\database classes\Plugins" + username + ".txt", form);//save the form to a file
            usernameInput.GetComponent<InputField>().text = "";
            passwordInput.GetComponent<InputField>().text = "";
            confPasswordInput.GetComponent<InputField>().text = "";
            print("Registratie succesvol");
        }
    }
}
