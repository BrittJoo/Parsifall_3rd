using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingArrayOrList : MonoBehaviour {

    [SerializeField]
    List<TestingDataClass> stellingen = new List<TestingDataClass>();

	// Use this for initialization
	void Start ()
    {

        stellingen.Add(new TestingDataClass("Statement",100,25,0,50)); // Eerste stelling
        stellingen.Add(new TestingDataClass("Statement",50,25,100,0)); // Tweede stelling
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        //characterOne += stellingen[0].classAwnserValue4;
        //characterTwo += stellingen[0].classAwnserValue3;

        //characterOne += stellingen[1]
    }
}
