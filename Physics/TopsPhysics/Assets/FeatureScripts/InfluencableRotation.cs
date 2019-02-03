using Assets.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluencableRotation : MonoBehaviour, IInput2dDirection{
    Vector3 influenceVector = Vector3.zero;
    public float powerPerInput;
    public GameObject mainCamera;

    public void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag(Constants.MainCamera);
    }

    public void AddInfluence(Constants.Direction2D input)
    {
        var inputInfluce = MakeVectorWithPower(input, powerPerInput);
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

    public void 
}
