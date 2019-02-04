using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {
    public GameObject ObjectToFollow;
    public float maxDistance;
    public float minDistance;
    private float heightPosition;

	// Use this for initialization
	void Start () {
        heightPosition = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        var differenceVector = ObjectToFollow.transform.position - this.transform.position;

        if (differenceVector.magnitude > maxDistance)
        {
            this.transform.position = ObjectToFollow.transform.position - (differenceVector.normalized * maxDistance);
        }
        else if(differenceVector.magnitude < minDistance)
        {
            this.transform.position = ObjectToFollow.transform.position - (differenceVector.normalized * minDistance);
        }
        this.transform.position = new Vector3(this.transform.position.x, heightPosition, this.transform.position.z);
        this.transform.LookAt(ObjectToFollow.transform);
	}
}
