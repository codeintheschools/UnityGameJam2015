using UnityEngine;
using System.Collections;

public class CheckGround : MonoBehaviour {

	private PlayerMove player;

	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	void Start () 
	{
	
		player = gameObject.GetComponent<PlayerMove> ();

	}
	
	void FixedUpdate ()

	{
		player.grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

	}



}
