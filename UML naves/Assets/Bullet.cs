using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour {


	protected float Damage = 10;
	protected Vector3 DirectionB = new Vector3();
	protected float speed = 5;
	protected float Waittodestroy = 5;

	// Use this for initialization
	public virtual void Start () {
		Invoke ("Destroy", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public virtual void MoveBullet (){

	}

	public virtual void ApplyDamage(){

	}



}
