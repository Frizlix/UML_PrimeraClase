using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplebullet : Bullet {
	

	// Use this for initialization
	override public void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += Vector3.up * speed * Time.deltaTime;
	}


}
