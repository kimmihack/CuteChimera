using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour 
{

	public float gameStartDelay;
	public float spawnSeconds;
	public bool readynow;
	public int spawnDelayMin;
	public int spawnDelayMax;

	public GameObject spawn;

	public GameObject animalPrefab;
	public Sprite[] animalSprites;


	// Use this for initialization
	void Start() 
	{
		Invoke ("gameStart", gameStartDelay);
		//StartCoroutine(startSpawnWait());
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
		yield return new WaitForSeconds (gameStartDelay);

	}

	// The Amount of time the animal sprite is on the screen

	IEnumerator spawnDelay()
	{
		int delayTime = Random.Range (spawnDelayMin, spawnDelayMax);
		yield return new WaitForSeconds (spawnSeconds + delayTime);
		readynow = true;
	}

	void gameStart() 
	{
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