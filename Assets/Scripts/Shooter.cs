using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
	public GameObject rocketPrefab;
	public Transform shootPoint;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			Quaternion rocketRot = Quaternion.Euler(shootPoint.rotation.eulerAngles.x + 90, shootPoint.rotation.eulerAngles.y, shootPoint.rotation.eulerAngles.z);	
			GameObject rocket = Instantiate(rocketPrefab, shootPoint.position, rocketRot);
			Rigidbody rocketRb = rocket.GetComponent<Rigidbody>();
			rocketRb.velocity = shootPoint.forward * 20f;
		}
	}
}
