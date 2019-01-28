using System.Collections;
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
        rigidBody.AddRelativeTorque(Vector3.forward * InitialTorque * (ReverseDirection ? 1 : -1));
	}
	
	// Update is called once per frame
	void Update () {
        rigidBody.AddRelativeTorque(Vector3.forward * EngineTorque * (ReverseDirection ? 1 : -1));
	}
}
