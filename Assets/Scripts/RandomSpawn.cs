using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour 
{

	public float spawnSeconds;
	public bool readynow;

	public GameObject spawn;

	public GameObject animalPrefab;
	public Sprite[] animalSprites;


	// Use this for initialization
	void Start() 
	{
		StartCoroutine(startSpawnWait());
		readynow = true;
	}

	void Update() 
	{
		if (readynow == true) 
		{
			spawnAnimal();
		}

	}
		
	// The Delay at the start of the game

	IEnumerator startSpawnWait()
	{
		yield return new WaitForSeconds (spawnSeconds);

	}

	// The Amount of time the animal sprite is on the screen

	IEnumerator spawnDelay()
	{
		//int delayTime = Random.Range (4, 10);
		yield return new WaitForSeconds (spawnSeconds + 3);
		readynow = true;
	}

	// Spawn a random animal sprite

	void spawnAnimal()
	{
		// Render the Animal Sprite
		readynow = false;
		int arrayIdx = Random.Range (0, animalSprites.Length);
		Sprite animalSprite = animalSprites[arrayIdx];
		string animalName = animalSprite.name;

		Instantiate (spawn, transform.position, Quaternion.identity);
		spawn.name = animalName;
		spawn.GetComponent<SpriteRenderer> ().sprite = animalSprite;

		StartCoroutine(spawnDelay());
	}
}