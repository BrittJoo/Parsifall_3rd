    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingArrayOrList : MonoBehaviour {

    public List<Character1PointsData> char1Points = new List<Character1PointsData>();
    public List<Character2PointsData> char2Points = new List<Character2PointsData>();
    public List<Character3PointsData> char3Points = new List<Character3PointsData>();

    private AcceptChoice acceptChoice;
    private Answers answers;
    private CharacterResult characterResult;

    private DataSavingTest savingData;

    public int[] charArray;

    private int characterOne =0;
    private int characterTwo =1;
    private int characterThree =2;
    private int characterFour;
    private int characterFive;
    private int characterSix;
    private int highestInt;
   // private int currentStatement;

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
        characterResult = FindObjectOfType<CharacterResult>();


        char1Points.Add(new Character1PointsData(100, 25, 0, 50)); // Eerste stelling)
        char1Points.Add(new Character1PointsData(0, 50, 100, 25)); // Tweede stelling)
        char1Points.Add(new Character1PointsData(25, 100, 50, 0)); // derde stelling)

        char2Points.Add(new Character2PointsData(0, 50, 100, 25)); // Eerste stelling)
        char2Points.Add(new Character2PointsData(100, 25, 0, 50)); // tweede stelling)
        char2Points.Add(new Character2PointsData(50, 50, 25, 100)); // derde stelling)

        char3Points.Add(new Character3PointsData(4, 3, 2, 1, "characterThree")); // Eerste stelling)
        char3Points.Add(new Character3PointsData( 1, 2, 3, 4, "characterThree")); // tweede stelling)
        char3Points.Add(new Character3PointsData(2, 4, 1, 3, "characterThree")); // derde stelling)
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
        }

        if (acceptChoice.currentStatement == 2)
        {
            Debug.Log("current statement is 3");
            characterResult.GetTheHighest(charArray, highestInt);
            Debug.Log("highest int is calculated");
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
