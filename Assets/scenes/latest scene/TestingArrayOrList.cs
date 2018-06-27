﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingArrayOrList : MonoBehaviour {

    public List<Character1PointsData> char1Points = new List<Character1PointsData>();
    public List<Character2PointsData> char2Points = new List<Character2PointsData>();
    public List<Character3PointsData> char3Points = new List<Character3PointsData>();

    private AcceptChoice acceptChoice;
    private Answers answers;

    private DataSavingTest savingData;

    public int[] charArray;

    private int characterOne =0;
    private int characterTwo =1;
    private int characterThree =2;
    private int characterFour;
    private int characterFive;
    private int characterSix;

    public int currentCharacter = 0;
    public int[] answerValue;

    public int[] statementAnswers;

    [SerializeField]
    private int maxStatements;

    // Use this for initialization
    void Start ()
    {
        statementAnswers = new int[18];
        charArray = new int[3];
        answerValue = new int[3];
        acceptChoice = FindObjectOfType<AcceptChoice>();
        answers = FindObjectOfType<Answers>();
        savingData = FindObjectOfType<DataSavingTest>();


        char1Points.Add(new Character1PointsData(100, 25, 0, 50)); // Eerste stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 25)); // Tweede stelling)

        char2Points.Add(new Character2PointsData(0, 50, 100, 25)); // Eerste stelling)
        char2Points.Add(new Character2PointsData(100, 25, 0, 50)); // tweede stelling)

        char3Points.Add(new Character3PointsData( 4, 3, 2, 1)); // Eerste stelling)
        char3Points.Add(new Character3PointsData( 1, 2, 3, 4)); // tweede stelling)
    }

    public void Update()
    {
        StoreData();
    }

    // Update is called once per frame
    public int GivePoints (int classAwnserValue, int character)
    {
        character += classAwnserValue;
        return character;
    }

    public void SaveAnswer()
    {
        statementAnswers[acceptChoice.currentStatement] = answers.givenAnswer;
        //Debug.Log(statementAnswers);
    }

    public void AnswerCharLoop()
    {
        foreach (int o in charArray)
        {
            charArray[currentCharacter] = GivePoints(answerValue[currentCharacter], o);
            currentCharacter++;

            

            //Debug.Log("answer value 0 : " + answerValue[0]);
            //Debug.Log("answer value 1 : " + answerValue[1]);
            //Debug.Log(currentCharacter + " = current Car");
        }

        currentCharacter = 0;
    }

    public void StoreData()
    {
        // PlayerPrefs.SetString("CharNameOne", "Loner");

        if (acceptChoice.currentStatement >= maxStatements)
        {
            savingData.SaveData("Loner", "Optimist", "Pesimist", characterOne, characterTwo, characterThree, acceptChoice.currentStatement, answers.givenAnswer);

            Debug.Log("Character One Name: " + PlayerPrefs.GetString("Character One Name: ") + ". Score: "  + PlayerPrefs.GetInt("Loner Score"));
        }

        //Debug.Log(PlayerPrefs.GetString("CharNameOne"));
    }
}
