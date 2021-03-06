﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class AcceptChoice : MonoBehaviour {
    
    public string[] statementText;//= new string[] {"Statement1", "Statement2", "Statement3"};
    public int[] characterScore;

    public bool overMouse;
    public bool hasAccepted;

    private PaddleController _paddleController;
    private Answers answers;
    private TestingArrayOrList testingArrayOrList;
    private AcceptChoice acceptChoice;
    private CharacterResult characterResult;
    private int highestInt = 0;

    private int[] charArray;

    public Text StatementTextObject;

    public Slider swordSlider;
  //  List<int> statement = new List<int>();
    public int currentStatement;
    int lastStatement;

    int snapPoint;
    int currentTextIndex = 0;
    bool canClickNext = true;

    private paddle paddle;

#region Junk
    //[SerializeField] List<int> statement = new List<int>();
    //[SerializeField] List<int> character = new List<int>();
    //[SerializeField] List<int> answers = new List<int>();


    void Start()
    {
        answers = FindObjectOfType<Answers>();
        testingArrayOrList = FindObjectOfType<TestingArrayOrList>();
        characterResult = FindObjectOfType<CharacterResult>();
        charArray = testingArrayOrList.charArray;
        //acceptChoice = FindObjectOfType<AcceptChoice>();

        //charArray = acceptChoice.charArray;
        //  int indexChar = character.IndexOf(120);
        // List.IndexOf(character);


        //    statement.Add(1);
        //    statement.Add(2);
        //    statement.Add(3);
        //    statement.Add(4);
        //    statement.Add(5);
        //    statement.Add(6);
        //    statement.Add(7);
        //    statement.Add(8);
        //    statement.Add(9);
        //    statement.Add(10);
        //    statement.Add(11);
        //    statement.Add(12);
        //    statement.Add(13);
        //    statement.Add(14);
        //    statement.Add(15);
        //    statement.Add(16);
        //    statement.Add(17);
        //    statement.Add(18);
        //    statement.Add(19);
        //    statement.Add(20);

        //    foreach (int o in statement)
        //    {
        //        for (int i = 0; i< 6; i++)
        //        {
        //            character.Add(i);
        //        }
        //    }

        //    foreach (int p in character)
        //    {
        //        for (int i = 0; i< 4; i++)
        //        {
        //            answers.Add(i);
        //        }
        //    }
        //    currentStatement = 1;
        //    lastStatement = 1;
    }

    #endregion


    public void ClickingTask()
    {
        hasAccepted = true;
        if (canClickNext)
        {
            answers.AnswerValueCheck();
            var statementDatas = ScriptableObject.CreateInstance<ScoreKeeper>();
            answers.GetData();
            lastStatement = currentStatement;

            StatementTextObject.text = statementText[currentTextIndex];
            currentTextIndex++;
            //if (swordSlider.value == 0)
            //{
            //    Debug.Log("give a charecter a point");
            //}

            //if(swordSlider.value == 1){ }
            //if (swordSlider.value == 2) { }
            //if (swordSlider.value == 3) {Debug.Log("je hebt oneens geselecteerd"); }
            // Antwoord.CheckValue()

            //loop functie givepoints
            testingArrayOrList.SaveAnswer();
             currentStatement++;
            Debug.Log(currentStatement);



        }

        if (currentTextIndex == 5 || currentTextIndex == 11 || currentTextIndex == 18)
        {
            canClickNext = false;
            StartCoroutine(Wait(5));
        }

        hasAccepted = false;
    }

    public IEnumerator Wait(float waitTime)
    {
        this.gameObject.GetComponent<Image>().enabled = false;
        this.gameObject.GetComponentInChildren<Text>().enabled = false;
        yield return new WaitForSeconds(waitTime);
        canClickNext = true;
        this.gameObject.GetComponentInChildren<Text>().enabled = true;
        this.gameObject.GetComponent<Image>().enabled = true;
    }
}