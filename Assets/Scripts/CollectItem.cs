using UnityEngine;
using System.Collections;

public class CollectItem : MonoBehaviour 
{
	// An event which sends an integer.
	public event System.Action<int> OnCollectItem;

	// This is the score value of the item, to be sent to the Score script, or whatever is listening
	public int scoreValue = 0;

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.CompareTag("Player"))
		{
			//Debug.Log ("Sending Event");
			// First Safety check to make sure that someone is listening. . . then send event.
			if(OnCollectItem != null) OnCollectItem(scoreValue);
			Destroy(this.gameObject);
		}
	}
}
