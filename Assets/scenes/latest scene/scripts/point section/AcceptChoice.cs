using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class AcceptChoice : MonoBehaviour {


    private Answers answers;
    private TestingArrayOrList testingArrayOrList;
    private CharacterResult characterResult;

    public Text StatementTextObject;

    private bool canClickNext = true;
    public bool hasAccepted;

    private int[] charArray;
    public string[] statementText;//= new string[] {"Statement1", "Statement2", "Statement3"};

    private int lastStatement;
    private int currentTextIndex = 0;
    public int currentStatement;


    void Start()
    {
        answers = FindObjectOfType<Answers>();
        testingArrayOrList = FindObjectOfType<TestingArrayOrList>();
        characterResult = FindObjectOfType<CharacterResult>();
        charArray = testingArrayOrList.charArray;
    }



    public void ClickingTask()
    {
        hasAccepted = true;
        if (canClickNext)
        {
            answers.AnswerValueCheck();
            var statementDatas = ScriptableObject.CreateInstance<ScoreKeeper>();
            lastStatement = currentStatement;

            StatementTextObject.text = statementText[currentTextIndex];
            currentTextIndex++;
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