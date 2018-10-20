using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Canon {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (islaunched == false){
			InvokeRepeating ("shoot", 1f, 0);
			islaunched = true;
	}
	}

	public override void shoot(){
		Instantiate (Bullet, this.transform.position, this.transform.rotation);
		islaunched = false;
	}
}
