using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowsIsGrounded : MonoBehaviour {
    public bool IsGrounded{get; set;}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == Constants.Bowl)
        {
            IsGrounded = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == Constants.Bowl)
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
    }

}
