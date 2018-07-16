using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryImageSlideController : MonoBehaviour {
    
    // Variables to set the new position and to have it move 
    // slowly towards it
    private float newPosition;
    private float smoothMove;


    // These values will be given the position of the object as set in Unity during the "start" phase
    private float currentZ;
    private float currentY;

    // This has to be filled in, and given a length, at the inspector
    // Length should be ammount of statements + breaks (i.e 24 statements + 2 breaks + end = 27 in length)
    [SerializeField]
    private float[] nextPosition;

    private AcceptChoice acceptChoice;

	// Use this for initialization
	void Awake ()
    {
        // This gives the variable it's initial value which later
        // gets increased during play time
        newPosition = nextPosition[0];
        smoothMove = newPosition;

        

        // Give the values that were set in unity
        currentZ = transform.position.z;
        currentY = transform.position.y;

        transform.position = new Vector3(nextPosition[0], currentZ, currentY);

        acceptChoice = FindObjectOfType<AcceptChoice>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        // Have the position of the story image
        // change slowly to the required position
        if(smoothMove > newPosition)
        {
            smoothMove--;
            
        }
        // set the new position of the story image
        transform.position = new Vector3(smoothMove, currentY, currentZ);



        Debug.Log("new position" + newPosition);
        Debug.Log("smooth" + smoothMove);
        //Debug.Log("x position" + transform.position.x);
	}

    // Function that sets the value of newPosition accordingly
    // Should only be called upon when the player presses the accept button
    public void MoveStoryImage()
    {
        newPosition = nextPosition[acceptChoice.currentStatement+1];
    }


}
