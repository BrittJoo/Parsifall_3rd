using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "StatementKeeper", order = 1)]
public class ScoreKeeper : ScriptableObject
{
    public int[][] jaggedArrayStatements = new int[3][];
    private AcceptChoice acceptChoice;

    void Start()
    {
        acceptChoice = FindObjectOfType<AcceptChoice>();

        jaggedArrayStatements[0] = new int[1] { acceptChoice.currentStatement };
        jaggedArrayStatements[1] = new int[4] { 1, 2, 3, 4 }; ;
        jaggedArrayStatements[2] = new int[6];

    }

    void Update()
    {

    }
}
