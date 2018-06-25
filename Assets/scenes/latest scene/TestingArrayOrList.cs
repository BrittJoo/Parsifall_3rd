using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingArrayOrList : MonoBehaviour {

    public List<TestingDataClass> stellingen = new List<TestingDataClass>();
    private AcceptChoice acceptChoice;

    private int characterOne;
    private int characterTwo;
    private int characterThree;
    private int characterFour;
    private int characterFive;
    private int characterSix;

    // Use this for initialization
    void Start ()
    {

        stellingen.Add(new TestingDataClass("Statement",100,25,0,50)); // Eerste stelling
        stellingen.Add(new TestingDataClass("Statement",50,25,100,0)); // Tweede stelling
	}

    private void Update()
    {
            for (int i = 0; i < 18; i++)
            {
            if (acceptChoice.hasAccepted)
            {

                acceptChoice.hasAccepted = false;
            }
            }
    }

    // Update is called once per frame
    public int GivePoints (int classAwnserValue, int character)
    {


        character += classAwnserValue;

        return character;

        

        //characterOne += classAwnserValue;
        //characterTwo += /*stellingen[0].*/classAwnserValue;
        //characterThree += classAwnserValue;

        //characterOne += stellingen[1]
    }
}
