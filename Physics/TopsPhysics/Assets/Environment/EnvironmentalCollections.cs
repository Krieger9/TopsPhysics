using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentalCollections : MonoBehaviour {
    public GameObject[] BowlArena { get; set; }
    public GameObject[] PlayerTops { get; set; }
	// Use this for initialization
	void Start () {
        BowlArena = GameObject.FindGameObjectsWithTag(Constants.BowlArena);
        PlayerTops = GameObject.FindGameObjectsWithTag(Constants.PlayerTop);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
