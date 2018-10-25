using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBuilding : Building {

    private string resType;
    private int resPerTick = 2;
    private int resCount = 0;


    //Image Refrence accessed on [04/09/2018]
    //Image Name :Brazil prosecutors demand crackdown on illegal gold mining in Amazon's El Dorado
    //Image Created by Unknown
    //https://steelguru.com/mining/brazil-prosecutors-demand-crackdown-on-illegal-gold-mining-in-amazon-s-el-dorado/480249 

    //methods
    public void GenerateRes()
    {
        resCount += resPerTick;
    }

    public override void Death()
    {
        //A method to handle the death of this unit
    }

    public override string ToString()
    {
        string str = "";
        //str = "Resource Building" + Environment.NewLine + "Fraction: " + fraction + "(" + xPos + "," + yPos + ")" + Environment.NewLine + "Health: " + hP + Environment.NewLine + "Resource: " + resType + " " + resCount;
        return str;
    }

    //gets the values
    public int XPos
    {
        get { return xPos; }
        set { xPos = value; }
    }
    public int YPos
    {
        get { return yPos; }
        set { yPos = value; }
    }
    public int HP
    {
        get { return hP; }
        set { hP = value; }
    }
    public int ResCount
    {
        get { return resCount; }
        set { resCount = value; }
    }
    public string Fraction
    {
        get { return fraction; }
        set { fraction = value; }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
