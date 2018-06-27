using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour {

    private AcceptChoice acceptChoice;
    private TestingArrayOrList testingArrayOrList;
    //private Character1PointsData character1PointsData;
    //private Character2PointsData character2PointsData;

    private int answerValue;

    public int givenAnswer;
    public Slider swordSlider;

    void Start()
    {
        acceptChoice = FindObjectOfType<AcceptChoice>();
        testingArrayOrList = FindObjectOfType<TestingArrayOrList>();
    }  


    public void AnswerValueCheck()
    {
        if (swordSlider.value == 0)
        {
            givenAnswer = 1;
            if (acceptChoice.hasAccepted)
            {
                testingArrayOrList.answerValue[0] = testingArrayOrList.char1Points[acceptChoice.currentStatement].classAwnserValue1;
                testingArrayOrList.answerValue[1] = testingArrayOrList.char2Points[acceptChoice.currentStatement].classAwnserValue1;
                testingArrayOrList.answerValue[2] = testingArrayOrList.char3Points[acceptChoice.currentStatement].classAwnserValue1;
                testingArrayOrList.AnswerCharLoop();
            }
        }
        if (swordSlider.value == 1)
        {
            givenAnswer = 2;
            if (acceptChoice.hasAccepted)
            {
                testingArrayOrList.answerValue[0] = testingArrayOrList.char1Points[acceptChoice.currentStatement].classAwnserValue2;
                testingArrayOrList.answerValue[1] = testingArrayOrList.char2Points[acceptChoice.currentStatement].classAwnserValue2;
                testingArrayOrList.answerValue[2] = testingArrayOrList.char3Points[acceptChoice.currentStatement].classAwnserValue2;
                testingArrayOrList.AnswerCharLoop();
            }
        }
        if (swordSlider.value == 2)
        {
            givenAnswer = 3;
            if (acceptChoice.hasAccepted)
            {
                testingArrayOrList.answerValue[0] = testingArrayOrList.char1Points[acceptChoice.currentStatement].classAwnserValue3;
                testingArrayOrList.answerValue[1] = testingArrayOrList.char2Points[acceptChoice.currentStatement].classAwnserValue3;
                testingArrayOrList.answerValue[2] = testingArrayOrList.char3Points[acceptChoice.currentStatement].classAwnserValue3;
                testingArrayOrList.AnswerCharLoop();
            }
        }

        if (swordSlider.value == 3)
        {
            givenAnswer = 4;
            if (acceptChoice.hasAccepted)
            {
                testingArrayOrList.answerValue[0] = testingArrayOrList.char1Points[acceptChoice.currentStatement].classAwnserValue4;
                testingArrayOrList.answerValue[1] = testingArrayOrList.char2Points[acceptChoice.currentStatement].classAwnserValue4;
                testingArrayOrList.answerValue[2] = testingArrayOrList.char3Points[acceptChoice.currentStatement].classAwnserValue4;
                 testingArrayOrList.AnswerCharLoop();
            }
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
