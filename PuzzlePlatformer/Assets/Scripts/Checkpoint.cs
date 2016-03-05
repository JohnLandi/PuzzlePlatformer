using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{
	public GameController gc;

	// Use this for initialization
	void Start ()
	{
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == ("Player1"))
			gc.player1Checkpoint  = this.gameObject;

		if(other.gameObject.tag == ("Player2"))
			gc.player2Checkpoint  = this.gameObject;

		if(other.gameObject.tag == ("Player3"))
			gc.player3Checkpoint  = this.gameObject;

		if(other.gameObject.tag == ("PickUp"))
			gc.objectCheckpoint  = this.gameObject;
	}
}

