using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateAround : MonoBehaviour {
    public string InstantiateTo;
    public float PieceCount;
    public GameObject PieceToRotate;
    public List<GameObject> createdObjects = new List<GameObject>();

	// Use this for initialization
	void Start () {
        DoDuplication360();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void DoDuplication360()
    {
        var rotationDegrees = 360f / PieceCount;
        var startLocation = PieceToRotate.transform.position;
        var startRotation = PieceToRotate.transform.rotation;
        var WallCollidersParent = transform.Find(InstantiateTo);

        for(float counter = 0; counter < PieceCount; counter++)
        {
            var newPiece = Instantiate<GameObject>(PieceToRotate,WallCollidersParent.transform);
            newPiece.transform.position = Quaternion.Euler(0, rotationDegrees * counter, 0) * startLocation;
            newPiece.transform.rotation = startRotation;
            newPiece.transform.Rotate(-this.transform.up, rotationDegrees * counter,Space.World);
            newPiece.SetActive(true);
        }
    }
}
