using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 

{

	public float trackSpeed;

	public Transform camTarget;

	

	void FixedUpdate ()
	
	{
	

			float targetX =  transform.position.x;

			targetX = Mathf.Lerp (transform.position.x, camTarget.position.x, trackSpeed * Time.deltaTime);

			transform.position = new Vector3 (targetX, transform.position.y, transform.position.z);

		   

	}

}
