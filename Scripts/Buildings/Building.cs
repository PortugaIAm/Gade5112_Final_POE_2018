using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : GameEngine {

    //Fields
    protected string Name;
    protected int xPos;
    protected int yPos;
    protected int hP = 100;
    protected string fraction;
    protected string image = "Factory.png";

    //methods
    public Building()
    {
        //Constructer to the builder class
    }
    public virtual void Death()
    {
        //A method to handle the death of this unit
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
