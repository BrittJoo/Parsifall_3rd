using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

    public InputField classCode;
    private string ClassCode;
    private bool classCodeValid;
    private string[] lines;

	void Start ()
    {
        ClassCode = classCode.GetComponent<InputField>().text;
	}

    // private string form
    // in loginbutton; 
    // form = (UserCode)
    // System.IO.File.WriteAllText(@H:\__ making games\Praktijk Route\Tryater\Networking tries\Assets\Plugins"+UserCode+".txt", form);
    //usercode.GetComponent<Inputfield>().text = "";

    public void LogInButton()
    {
        bool CC = false;
        if (ClassCode != "")
        {
            if (System.IO.File.Exists(@"C:\Making games\Praktijk Route\Tryater\Networking tries\Assets\scenes\database classes\Plugins" +
                                      ClassCode + ".txt"))
            {
                CC = true;
                lines = System.IO.File.ReadAllLines(
                    @"C:\Making games\Praktijk Route\Tryater\Networking tries\Assets\scenes\database classes\Plugins" +                    
                    ClassCode + ".txt");
            }
            else
            {
                Debug.LogWarning("Student nummer al in gebruik");
            }
        }
        else
        {
            Debug.LogWarning("Student nummer leeg");
        }

        if (CC)
        {
            classCode.GetComponent<InputField>().text = "";
            SceneManager.LoadScene(1);
        }
    }
	
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.Return))
	    {
	        if (ClassCode != "")
	        {
                LogInButton();
	        }
	    }
	}
}
