using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentalVariables : MonoBehaviour {
    public Vector3? Gravity = new Vector3(0f, -10f, 0f);
	// Use this for initialization
	void Start () {
	    if(Gravity != null)
        {
            Physics.gravity = Gravity.Value;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
