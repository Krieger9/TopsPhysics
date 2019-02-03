using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {
    public InfluencableRotation influence;
    public float minTimeDelta;

    private Constants.Direction2D lastMessageSent = Constants.Direction2D.NONE;
    private float timeLastMessageSent;

    public void UpEntered()
    {
        influence.AddInfluence(Constants.Direction2D.UP);
    }
    public void DownEntered()
    {
        influence.AddInfluence(Constants.Direction2D.DOWN);
    }
    public void LeftEntered()
    {
        influence.AddInfluence(Constants.Direction2D.LEFT);
    }
    public void RightEntered()
    {
        MakeInfluence(Constants.Direction2D.RIGHT);
    }

    private void MakeInfluence(Constants.Direction2D direction)
    {
        if(direction != lastMessageSent || Time.time > (timeLastMessageSent + minTimeDelta))
        {
            lastMessageSent = direction;
            timeLastMessageSent = Time.time;
            influence.AddInfluence(direction);
        }
    }
	// Use this for initialization
	void Start () {
        		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.A))
        {
            LeftEntered();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            DownEntered();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            RightEntered();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            UpEntered();
        }
	}
}
