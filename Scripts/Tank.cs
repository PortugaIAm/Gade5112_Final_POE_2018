using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : RangedUnit {

	// Use this for initialization
	void Start () {
        //changing the stats of the unit
        hP = 80;
        atk = 30;
        atkRange = 1;
        speed = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
