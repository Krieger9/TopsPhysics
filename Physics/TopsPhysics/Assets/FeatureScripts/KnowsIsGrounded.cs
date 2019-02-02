using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowsIsGrounded : MonoBehaviour {
    public bool IsGrounded{get; set;}

    private GameObject groundedToObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == Constants.BowlChunk && collision.gameObject == groundedToObject)
        {
            groundedToObject = null;
            IsGrounded = false;
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == Constants.BowlChunk && collision.gameObject != groundedToObject)
        {
            OnCollisionEnter(collision);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == Constants.BowlChunk)
        {
            if(groundedToObject != collision.gameObject)
            {
                groundedToObject = collision.gameObject;
                IsGrounded = true;
            }
        }
    }
}
