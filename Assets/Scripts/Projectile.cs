using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * 10);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
