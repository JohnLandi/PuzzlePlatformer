using UnityEngine;
using System.Collections;

public class WalkingEnemy : MonoBehaviour
{
	public int moveSpeed;

	public GameController gc;


	// Use this for initialization
	void Start ()
	{
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == ("Player1"))
			gc.playerRespawn1();
		
		else
			if(coll.gameObject.tag == ("Player2"))
				gc.playerRespawn2();
		
			else
				if(coll.gameObject.tag == ("Player3"))
					gc.playerRespawn3();
		
				else
						moveSpeed = -moveSpeed;
	}
}

