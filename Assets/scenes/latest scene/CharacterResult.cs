using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharacterResult : MonoBehaviour {

    public GameObject ch1;
    public GameObject ch2;
    public GameObject ch3;

    private int resultChar;

    public int GetTheHighest(int[] allScores, int highestInt)
    {
        highestInt = allScores.Max();
        Debug.Log(highestInt);
        

        if (allScores[0] == highestInt)
        {
            Debug.Log("character one has the most points");
            ch1.SetActive(true);
            resultChar = 1;
        }

        if (allScores[1] == highestInt)
        {
            Debug.Log("character two has the most points");
            ch2.SetActive(true);
            resultChar = 2;
        }

        if (allScores[2] == highestInt)
        {
            Debug.Log("character three has the most points");
            ch3.SetActive(true);
            resultChar = 3;
        }

        return highestInt;
    }
}
