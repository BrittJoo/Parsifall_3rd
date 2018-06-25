using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

  //  [SerializeField] ArrayList Stellingen = new ArrayList(18);
    [SerializeField] List<int> Stellingen = new List<int>(18);
    //  public int[] characterScore = new int[6];
    [SerializeField] List<int> characterScore = new List<int>(6);

    private void Start()
    {
        foreach (object o in Stellingen)

            for (int i = 0; i < 6; i++)
            {
                //Stellingen.Add(characterScore(i));
                  //  characterScore.Add(i);
            }
        //{
        //    characterScore.Add[o];
        //}
    }
}
