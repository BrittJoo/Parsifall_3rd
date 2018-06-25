using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour {

    private AcceptChoice acceptChoice;
    public int givenAnswer;
    public Slider swordSlider;

	void Start ()
    {
        acceptChoice = FindObjectOfType<AcceptChoice>();

    }

    private void Update()
    {
        if (swordSlider.value == 0)
        {
            givenAnswer = 1;
        }
        if (swordSlider.value == 1)
        {
            givenAnswer = 2;
        }
        if (swordSlider.value == 2)
        {
            givenAnswer = 3;
        }
        if (swordSlider.value == 3)
        {
            givenAnswer = 4;
        }
    }


    public void GetData ()
    {
        int statement;
        int answer;
        statement = acceptChoice.currentStatement;
        answer = givenAnswer;
	}
}
