/* This script is to be put on the players bullets. It decideds which direction the players bullets should go in.
*/

using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	public float moveSpeed;
	private float timer;

	public GameController gc;

	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed , 0);
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if(timer >= 1f)
		{
			//	Debug.Log("fuck me right?");
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		//Debug.Log("balllllls");
		if(other.gameObject.tag == ("Player1"))
		{
			Debug.Log("fck this guys right here");
			gc.playerRespawn1();

		}

		else
			if(other.gameObject.tag == ("Player2"))
				gc.playerRespawn2();

			else
				if(other.gameObject.tag == ("Player3"))
					gc.playerRespawn3();

		Destroy (gameObject);
	}
}
