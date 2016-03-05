using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
	private GameController gc;

	private bool touching1 = false;
	private bool touching2 = false;
	private bool touching3 = false;
	private bool wasHit = false;

	public GameObject whatToDestroy;

	// Use this for initialization
	void Start ()
	{
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(gc.whichPlayer == 1 && touching1 == true && Input.GetButtonDown("Action"))
			whatToDestroy.SetActive (false);

		if(gc.whichPlayer == 2 && touching2 == true && Input.GetButtonDown("Action"))
			whatToDestroy.SetActive (false);

		if(gc.whichPlayer == 3 && touching3 == true && Input.GetButtonDown("Action"))
			whatToDestroy.SetActive (false);

		if(wasHit == true)
			whatToDestroy.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == ("Player1"))
			touching1 = true;

		if(other.gameObject.tag == ("Player2"))
			touching2 = true;

		if(other.gameObject.tag == ("Player3"))
			touching3 = true;

		if(other.gameObject.tag == ("PlayerBullet"))
			wasHit = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == ("Player1"))
			touching1 = false;

		if(other.gameObject.tag == ("Player2"))
			touching2 = false;

		if(other.gameObject.tag == ("Player3"))
			touching3 = false;
	}
}

