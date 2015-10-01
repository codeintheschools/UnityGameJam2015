using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 

{


	public float speed;
	public float jump;

	public float MoveVelocity;


	public bool grounded = true; 

	private Animator anim;
	


	void Start() 
	{

		anim = gameObject.GetComponent<Animator>(); 

	}

	void Update () 
	
	{
	

		//connects the variables we created here to the parameters we made in the Animator (here written in orange quotes)
		anim.SetBool ("grounded",grounded);
		anim.SetFloat ("MoveVelocity", Mathf.Abs(MoveVelocity));


		//Jump command, the vector 2 here is x and y, but x can't be set to 0, so we ask it to get the rigidbody's current x value and set it to that, y is our jump variable

		if (Input.GetKeyDown (KeyCode.Space) && grounded==true) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
		
		}
	
		//Move command, GetKeyDown is used for jump cause it's only called once (per frame?), "GetKey" is used for the movement so you can hold it down

		//sets the direction our character is going to move, right is positive, left is negative
		MoveVelocity = 0;

	
		if (Input.GetKey (KeyCode.RightArrow))
		{

			MoveVelocity = 1;


		}

		if (Input.GetKey (KeyCode.LeftArrow))
		{
			
			MoveVelocity = -1;


	
		}


	    //moves our character
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed * MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);



	//flips our character
		if (MoveVelocity > 0) {

			//makes our sprite face the way he is walking 
			transform.localScale = new Vector3 (Mathf.Abs (GetComponent<Transform> ().localScale.x), GetComponent<Transform> ().localScale.y, GetComponent<Transform> ().localScale.z);
		}

		if (MoveVelocity < 0) {
			//makes our sprite face the way he is walking, 6 is used cause that's the scale of our character 
			transform.localScale = new Vector3 (-6, GetComponent<Transform> ().localScale.y, GetComponent<Transform> ().localScale.z);
		
		}

	}




}
