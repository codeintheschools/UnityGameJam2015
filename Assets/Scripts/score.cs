using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	private CollectItem fromCollectItem;
	public GUIText scoreText;



	void Start () 
	{

		fromCollectItem = gameObject.GetComponent<CollectItem> ();
		fromCollectItem.score = 0;
		UpdateScore ();

	}

	public void AddScore (int newScoreValue)
	{
		fromCollectItem.score += newScoreValue;
		UpdateScore ();
	}


  	 void UpdateScore()
		{

		scoreText.text = "score " + fromCollectItem.score; 

		}


}
