using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets1peed : MonoBehaviour {
	public Rigidbody bullets;
		public Transform gun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
		{
			Rigidbody project;
			project = Instantiate(bullets, gun.position, gun.rotation) as Rigidbody;
			project.AddForce(gun.forward * 350f);
			
		}
	}
}

