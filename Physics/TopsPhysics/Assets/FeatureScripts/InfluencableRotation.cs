using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InfluencableRotation : MonoBehaviour{
    private Vector3 influenceVector = Vector3.zero;
    private Rigidbody rigidbody;
    private Quaternion PointerStartingRotation { get; set; }

    public GameObject InfluencePointer;
    public float powerPerInput;
    public GameObject mainCamera;

    public void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag(Constants.MainCamera);
        rigidbody = GetComponent<Rigidbody>();
        InfluencePointer = GameObject.FindGameObjectWithTag("InputPointer");
        if(InfluencePointer != null)
        {
            PointerStartingRotation = InfluencePointer.transform.rotation;
        }
    }
    
    public void FixedUpdate()
    {
        if (influenceVector != Vector3.zero && influenceVector.magnitude > .5)
        {
            rigidbody.AddTorque(-influenceVector * powerPerInput);
            if (InfluencePointer)
            {
                InfluencePointer.SetActive(true);
                InfluencePointer.transform.position = this.transform.position + (Vector3.up * 1);
                InfluencePointer.transform.LookAt(this.transform.position + influenceVector);
            }
        }
        else
        {
            InfluencePointer.SetActive(false);
        }
    }

    public void NoInfluence()
    {
        influenceVector += (Vector3.zero - influenceVector).normalized * powerPerInput;
    }

    public void AddInfluence(Constants.Direction2D input)
    {
        var inputInfluce = MakeVectorWithPower(input, powerPerInput);
        influenceVector += inputInfluce;
    }

    private Vector3 MakeVectorWithPower(Constants.Direction2D input, float powerPerInput)
    {
        switch(input)
        {
            case Constants.Direction2D.NONE:
                {
                    return Vector3.zero;
                }
            case Constants.Direction2D.UP:
                {
                    return mainCamera.transform.forward * powerPerInput;
                }
            case Constants.Direction2D.DOWN:
                {
                    return -mainCamera.transform.forward * powerPerInput;
                }
            case Constants.Direction2D.LEFT:
                {
                    return -mainCamera.transform.right * powerPerInput;
                }
            case Constants.Direction2D.RIGHT:
                {
                    return mainCamera.transform.right * powerPerInput;
                }
            default:
                {
                    throw new ArgumentException(String.Format("Invalid direction for Direction2D {0}", Enum.GetName(typeof(Constants.Direction2D), input)));
                }
        }
    }

}
