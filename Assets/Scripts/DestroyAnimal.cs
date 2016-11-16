using UnityEngine;
using System.Collections;

public class DestroyAnimal : MonoBehaviour {

	public GameObject spawnerObject;

	private RandomSpawn randomSpawnAcess;
	private float randomSpawnSeconds;

	// Use this for initialization
	void Start () {

		randomSpawnAcess = spawnerObject.GetComponent<RandomSpawn>();
		randomSpawnSeconds = randomSpawnAcess.spawnSeconds;
		Debug.Log (randomSpawnSeconds);

		Destroy (gameObject, randomSpawnSeconds);
	}
}
