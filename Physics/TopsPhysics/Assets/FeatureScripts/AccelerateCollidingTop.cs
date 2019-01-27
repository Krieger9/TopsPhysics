using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateCollidingTop : MonoBehaviour {
    public float Torque = 2000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PlayerTop")
        {
            var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
            if(rigidBody!=null)
            {
                rigidBody.AddTorque(new Vector3(0, Torque, 0));
            }
        }
    }
}
