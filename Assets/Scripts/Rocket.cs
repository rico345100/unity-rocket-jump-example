using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
	public GameObject explosionPrefab;
	GameObject player;

	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
		Physics.IgnoreCollision(GetComponent<Collider>(), player.GetComponent<Collider>());

		Invoke("Explode", 5);
	}

	void Explode() {
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<Collider>().enabled = false;

		GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
		Destroy(explosion, 3f);
		Destroy(gameObject, 3f);
	}

	void OnCollisionEnter(Collision other) {
		Explode();
	}
}
