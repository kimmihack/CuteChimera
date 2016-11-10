using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour 
{

	public float spawnSeconds;
	public bool readynow;

	public GameObject spawn;

	// Use this for initialization
	void Start() 
	{
		if (readynow == true) 
		{
			spawnAnimal();
		}
	}

	void Update() 
	{
		if (readynow == true) 
		{
			spawnAnimal();
		}
	}
		
	// Spawn a new animal every 3 seconds

	void spawnAnimal()
	{
		readynow = false;
		Instantiate (spawn, transform.position, Quaternion.identity);
		StartCoroutine(waitSeconds());
	}

		IEnumerator waitSeconds()
	{
		yield return new WaitForSeconds(spawnSeconds);
		readynow = true;
	}
}