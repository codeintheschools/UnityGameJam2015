using UnityEngine;
using System.Collections;

public class CollectItem : MonoBehaviour 

{

	public int score = 0;

	
	void OnTriggerEnter2D(Collider2D other) 
	
	{
		if (other.CompareTag("Player"))

		{

			score += 5;

			Destroy(this.gameObject);



		}


	}


}
