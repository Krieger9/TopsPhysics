using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopsGravityWell : MonoBehaviour {
    public float Gravity = 100;
    EnvironmentalCollections environmentCollections;   

	// Use this for initialization
	void Start () {
        environmentCollections = GameObject.FindGameObjectWithTag(Constants.Environment).GetComponent<EnvironmentalCollections>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
