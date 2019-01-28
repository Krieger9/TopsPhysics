using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WallAcceleratedTop : IsConnectedToOneOf{
    public float Torque;

    private Rigidbody TheRigidbody { get; set; }
    private Quaternion startRotation { get; set; }

	// Use this for initialization
	void Start () {
        ItemTypeTagString = Constants.WallChunk;
        TheRigidbody = GetComponent<Rigidbody>();
        startRotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FixedUpdate()
    {
        if(IsConnected)
        {
            transform.rotation = startRotation;
            TheRigidbody.AddRelativeTorque(this.transform.up * (Torque * Time.fixedDeltaTime));
        }
    }
}
