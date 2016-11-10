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
		if (readynow == true) 
		{
			StartCoroutine(spawnDelay());
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
		int arrayIdx = Random.Range (0, animalSprites.Length);
		Sprite animalSprite = animalSprites[arrayIdx];
		string animalName = animalSprite.name;

		Instantiate (spawn, transform.position, Quaternion.identity);
		spawn.name = animalName;
		spawn.GetComponent<SpriteRenderer> ().sprite = animalSprite;

		StartCoroutine(spawnDelay());
	}

	    IEnumerator spawnDelay()
	{
		int delayTime = Random.Range (5, 12);
		yield return new WaitForSeconds (delayTime);
		readynow = true;
	}
}