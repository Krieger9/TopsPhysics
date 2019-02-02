using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsConnectedToOneOf : MonoBehaviour {
    public bool IsConnected{get; set;}
    public string ItemTypeTagString;

    private GameObject groundedToObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == ItemTypeTagString && collision.gameObject == groundedToObject)
        {
            groundedToObject = null;
            IsConnected = false;
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == ItemTypeTagString && collision.gameObject != groundedToObject)
        {
            OnCollisionEnter(collision);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ItemTypeTagString)
        {
            if(groundedToObject != collision.gameObject)
            {
                groundedToObject = collision.gameObject;
                IsConnected = true;
            }
        }
    }
}
