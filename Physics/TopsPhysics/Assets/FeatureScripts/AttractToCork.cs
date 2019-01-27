using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(KnowsIsGrounded))]
[RequireComponent(typeof(Rigidbody))]
public class AttractToCork : MonoBehaviour {
    public bool NotWhenGrounded;
    public bool ActivateOnceGrounded;
    public float Force;

    private KnowsIsGrounded _knowsIsGrounded;

    public bool IsGrounded { get { return _knowsIsGrounded.IsGrounded; } }
    private GameObject TheCork { get; set; }
    private Rigidbody TheRigidbody { get; set; }
    private bool Activated { get; set; }

	// Use this for initialization
	void Start () {
        _knowsIsGrounded = GetComponent<KnowsIsGrounded>();
        TheCork = GameObject.FindGameObjectWithTag("Cork");
        TheRigidbody = GetComponent<Rigidbody>();
        if (!ActivateOnceGrounded) Activated = true;
	}

    void Update()
    {
        if (!Activated)
        {
            if(IsGrounded)
            {
                Activated = true;
            }
        }
    }
	// Update is called once per frame
	void FixedUpdate () {
	    if(Activated && (!IsGrounded || !NotWhenGrounded))
        {
            var directionTo = TheCork.transform.position - this.transform.position;
            TheRigidbody.AddForce(directionTo.normalized * (Force * Time.deltaTime));
        }
	}
}
