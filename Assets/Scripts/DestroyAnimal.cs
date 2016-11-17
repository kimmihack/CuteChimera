using UnityEngine;
using System.Collections;

public class DestroyAnimal : MonoBehaviour {

	public GameObject spawnerObject;
	public float animalScore;

	private RandomSpawn randomSpawnAcess;
	private float randomSpawnSeconds;

	// Use this for initialization
	//Accessing the spawnAliveSeconds from RandomSpawn Script
	void Start () 
	{
		randomSpawnAcess = spawnerObject.GetComponent<RandomSpawn>();
		randomSpawnSeconds = randomSpawnAcess.spawnAliveSeconds;
		Destroy (gameObject, randomSpawnSeconds);
	}

	void OnMouseUp()
	{ 
		animalScore++;
		Debug.Log (animalScore);
		//Destroy(gameObject); 
	}
}
