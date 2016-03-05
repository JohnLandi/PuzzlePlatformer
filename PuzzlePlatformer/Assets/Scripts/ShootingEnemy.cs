using UnityEngine;
using System.Collections;

public class ShootingEnemy : MonoBehaviour
{
	public GameObject enemyBullet;

	//private float waitTimer;
	public float activeTimer;

	private int shotCount;

	public GameController gc;


	// Use this for initialization
	void Start ()
	{
	//	waitTimer = 5;
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	//	waitTimer += Time.deltaTime;
		activeTimer += Time.deltaTime;

		shootingAndShit();


	}

	public void shootingAndShit()
	{
		if(activeTimer >= .5 && shotCount < 3)
		{
			Instantiate(enemyBullet, this.GetComponent<Transform>().position, this.GetComponent<Transform>().rotation);
			shotCount++;
			activeTimer = 0;
		}

		if(activeTimer >= 2)
		{
			shotCount = 0;
			activeTimer = 0;
		}
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
	}
}

