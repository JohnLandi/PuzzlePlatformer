﻿/*
 * 
*/


using UnityEngine;
using System.Collections;

public class PickUpObject : MonoBehaviour {

	private bool isHoldingSomething = false;
	private bool isTouching = false;
	private GameObject thisObject;
	private GameObject player3;
	public float fallSpeed = 1f;
	private bool grounded = true;
	public Transform groundCheck1;
	public Transform groundCheck2;
	//public float groundCheckRadius;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		thisObject = this.gameObject;
		player3 = GameObject.FindGameObjectWithTag("CarryPoint");
	}


	void FixedUpdate()
	{
		//grounded = Physics2D.OverlapCircle(groundCheck.position , groundCheckRadius , whatIsGround);

		grounded = Physics2D.OverlapArea(groundCheck1.position , groundCheck2.position , whatIsGround);

		if(grounded == false && isHoldingSomething == false)
		{
			transform.Translate(-Vector2.up * fallSpeed * Time.deltaTime);
		}


	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonUp("Fire1"))
		{
			thisObject.transform.parent = null;
			isHoldingSomething = false;
			this.GetComponent<BoxCollider2D>().size = new Vector2 (1f , 1f);
		}

		if (isHoldingSomething == false && Input.GetButton("Fire1") && isTouching == true)
		{
			thisObject.transform.parent = player3.transform;
			isHoldingSomething = true;
			this.GetComponent<BoxCollider2D>().size = new Vector2 (.9f , 1f);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "CarryPoint")
		{
			isTouching = true;
		}
	}

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "CarryPoint")
		{
			isTouching = false;
		}
	}

	/*void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player3")
		{
			isTouching = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player3")
		{
			isTouching = false;
		}
	}*/

	public void BecomeChild(Transform newParent)
	{
		
	}
}
