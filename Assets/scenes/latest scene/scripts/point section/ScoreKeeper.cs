using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "StatementKeeper", order = 1)]
public class ScoreKeeper : ScriptableObject
{
    public int[][] jaggedArrayStatements = new int[3][];
    private AcceptChoice acceptChoice;
    private int charPoints1;
    private int charPoints2;
    private int charPoints3;
    private int charPoints4;
    private int charPoints5;
    private int charPoints6;

    private Answers answers;

    void Start()
    {
        acceptChoice = FindObjectOfType<AcceptChoice>();

        //jaggedArrayStatements[0] = new int[1] { acceptChoice.currentStatement };
        //// jaggedArrayStatements[1] = new int[4] { 1, 2, 3,4}; ;
        // jaggedArrayStatements[1] = new int[1] { answers.givenAnswer}; ;

        jaggedArrayStatements[0] = new int[18] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
        jaggedArrayStatements[1] = new int[4] { 1, 2, 3, 4}; ;
        jaggedArrayStatements[2] = new int[6] { charPoints1, charPoints2, charPoints3, charPoints4, charPoints5, charPoints6 };  ;
    }

    void Update()
    {
        if (acceptChoice.currentStatement == 1)
        {
            //if (jaggedArrayStatements[1] == 1)
            //{
            //    charPoints1 = 1;
            //}
        }
    }
}
