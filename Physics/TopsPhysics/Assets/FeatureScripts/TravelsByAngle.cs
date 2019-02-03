using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TravelsByAngle : MonoBehaviour {
    public float AnglePowerFactor;
    public Rigidbody Rigidbody { get; set; }
	// Use this for initialization
	void Start () {
        Rigidbody = this.GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
        var TravelsByAngle = Vector3.Angle(Vector3.up, this.transform.up);
        var rotation = this.transform.rotation.eulerAngles.normalized;
        Rigidbody.AddForce(new Vector3(rotation.x, 0f, rotation.z) * (TravelsByAngle * AnglePowerFactor));
	}
}
