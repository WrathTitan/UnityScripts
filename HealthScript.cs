using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

	//public GameObject duplication;
	private float Health=100.0f;
	//private Transform mytomb;
	// Use this for initialization
	void Start () {
		//mytomb = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject != null) {
			if (Health <= 0) {
				DeathMethod ();
				Destroy (this.gameObject);
			}

		} 
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.CompareTag("Duplicate")) {
			Health -= 1f;
			Debug.Log(Health);
		
			//GameObject.Instantiate (duplication, mytomb);
		}
	}
	void DeathMethod()
	{
		SceneManager.LoadScene ("scenesimple");
	}
}
