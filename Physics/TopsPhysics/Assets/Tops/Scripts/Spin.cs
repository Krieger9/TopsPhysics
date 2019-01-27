﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
    public bool ReverseDirection = false;
    public float InitialTorque;
    public float EngineTorque;

    private Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = this.GetComponent<Rigidbody>();
        rigidBody.maxAngularVelocity = 200;
        rigidBody.AddTorque(Vector3.up * InitialTorque * (ReverseDirection ? 1 : -1));
	}
	
	// Update is called once per frame
	void Update () {
        rigidBody.AddTorque(Vector3.up * EngineTorque * (ReverseDirection ? 1 : -1));
	}
}
