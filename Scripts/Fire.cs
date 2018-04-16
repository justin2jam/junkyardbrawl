using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	public Rigidbody2D projectile;
	public KeyCode FireButton = KeyCode.Space;
	public float speed = 20;
    public Rigidbody2D bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(FireButton))
			{
			bullet = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
			bullet.velocity = transform.TransformDirection(new Vector2(speed,0));
			}
			
	}
}
