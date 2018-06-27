using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSavingTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void SaveData    (string characterOne, string characterTwo, string characterThree, 
                            int characterOneScore, int characterTwoScore, int characterThreeScore, 
                            int statement, int givenAnswer)
    {

        PlayerPrefs.SetString("Character One Name: ", characterOne);
        PlayerPrefs.SetInt(characterOne + " Score: ", characterOneScore);

        PlayerPrefs.SetString("Character Two Name: ", characterTwo);
        PlayerPrefs.SetInt(characterTwo + " Score: ", characterTwoScore);

        PlayerPrefs.SetString("Character Name: ", characterThree);
        PlayerPrefs.SetInt(characterThree + " Score: ", characterThreeScore);

        //PlayerPrefs.SetString("Character Name: ", characterFour);
        //PlayerPrefs.SetInt(characterFour + " Score: ", characterFourScore);

        //PlayerPrefs.SetString("Character Name: ", characterFive);
        //PlayerPrefs.SetInt(characterFive + " Score: ", characterFiveScore);

        //PlayerPrefs.SetString("Character Name: ", characterSix);
        //PlayerPrefs.SetInt(characterSix + " Score: ", characterSixScore);

        PlayerPrefs.SetInt("Statement Number: ", statement);
        PlayerPrefs.SetInt("Statement Answer: ", givenAnswer);

        PlayerPrefs.Save();

    }
}
