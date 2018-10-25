using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBuilding : Building {

    protected int gameTick;
    private int spawnX;
    private int spawnY;

    //public static BinaryFormatter BFormatter { get; set; }
    //public static FileStream FStream { get; set; }

    //Image Refrence accessed on [04/09/2018]
    //Image Name : Factory Plant Machine
    //Image Created by Clker-Free-Vector-Images
    //https://pixabay.com/en/factory-plant-machine-manufacturing-40621/

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
    public string Fraction
    {
        get { return fraction; }
        set { fraction = value; }
    }


    //methods
    public FactoryBuilding()
    {
        //this.map = map;
        //this.fm = fm;
        //this.rb = rb;
        //this.mU = mU;

    }
    public void Spawn()
    {
        //if (rb.ResCount == 10)
        //{
        //    // i just tried to get the map to spawn melee units but thde code didnt seem to work.
        //    spawnX = XPos + 1;
        //    spawnY = YPos + 1;
        //    if (map.arrPb[spawnX, spawnY].Name == "E")
        //    {
        //        MeleeUnit newMu = new MeleeUnit(map, fm);
        //        newMu.XPos = spawnX;
        //        newMu.XPos = spawnY;
        //        newMu.Fraction = fraction;
        //        map.arrPb[spawnX, spawnY] = newMu;
        //        map.placeUnits();
        //    }
        //    fm.gridM.Refresh();
        //}
    }
    public override void Death()
    {
        //A method to handle the death of this unit
    }
    public override string ToString()
    {
        string str = "null";
        //str = "Factory Building" + Environment.NewLine + "Fraction: " + fraction + Environment.NewLine + "(" + xPos + "," + yPos + ")" + Environment.NewLine + "Health: " + hP;
        return str;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
