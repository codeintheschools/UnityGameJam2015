using UnityEngine;
using System.Collections;

// Since this script depends on the other, might as well require it here.  Neat! right?
[RequireComponent(typeof (CollectItem) )]
public class Score : MonoBehaviour {

	private CollectItem fromCollectItem;
	public GUIText scoreText;

	/*
	 * static variables share their value with all instances of the script in the scene.
	 * "private" is because nothing else currently talks to the variable.
	 */
	private static int totalScore = 0;
	
	void Start ()
	{
		UpdateScore ();
		fromCollectItem = gameObject.GetComponent<CollectItem> ();
		fromCollectItem.OnCollectItem += AddScore; // Listening to the event deom CollectItem
	}

	public void AddScore (int newScoreValue) // What happens when this script hears that event
	{
		Score.totalScore += newScoreValue; // add to our static variable totalScore
		UpdateScore ();
	}


  	void UpdateScore()
	{
		scoreText.text = "TIPS " + Score.totalScore; // We might want to change this to the new UI
	}
}
