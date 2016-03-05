using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelObject : MonoBehaviour
{

//	int currentSceneIndex;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 
		SceneManager.LoadScene(currentSceneIndex + 1);
	}
}

