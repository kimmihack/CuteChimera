using UnityEngine;
using System.Collections;

public class DestoryAnimal : MonoBehaviour {

	public int aliveSeconds;

	// Use this for initialization
	void Start () {
		aliveSeconds = (Random.Range(2, 6));
		Destroy(gameObject, aliveSeconds);
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
