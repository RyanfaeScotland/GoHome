﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    public GameObject deathParticles; 
    private float maxSpeed = 5f;
    private Vector3 input;

    private Vector3 spawn;

	// Use this for initialization
	void Start () {
        spawn = transform.position;
	}
	
	// Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(input * moveSpeed);
        }
    }

    void OnCollisionEnter(Collision other){
        if (other.transform.tag == "Enemy")
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            transform.position = spawn;
        }
    }    
}
