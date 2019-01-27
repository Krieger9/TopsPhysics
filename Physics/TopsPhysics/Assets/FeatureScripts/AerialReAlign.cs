using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(KnowsIsGrounded))]
public class AerialReAlign : MonoBehaviour {
    public float Force;

    private KnowsIsGrounded _knowsIsGrounded;

    private Quaternion StartRotation { get; set; }
    private Rigidbody Rigidbody { get; set; }
    private bool IsGrounded { get { return _knowsIsGrounded.IsGrounded; } }
	// Use this for initialization
	void Start () {
        StartRotation = this.transform.rotation;
        Rigidbody = GetComponent<Rigidbody>();
        _knowsIsGrounded = GetComponent<KnowsIsGrounded>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(!IsGrounded)
        {
            var rotationDirection = Quaternion.FromToRotation(this.transform.rotation.eulerAngles, StartRotation.eulerAngles);
            transform.Rotate(rotationDirection.eulerAngles.normalized * (Force * Time.deltaTime));
        }
	}
}
