using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MeleeUnit : Unit {

    Unit u;
    float closX, closY;
    private Vector2 target;
    public GameEngine gm;
    public MeleeUnit()
    {
        //A constructor
        
    }
    
    protected int hP;
    protected int speed;
    protected int atk;
    protected int atkRange;
    protected string fraction;
    public int distance = 100;
    public int cX, cY,cUindex;
    int NxPos, NyPos;

    // getters and setters
    
    public int HP
    {
        get { return hP; }
        set { hP = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Atk
    {
        get { return atk; }
        set { atk = value; }
    }
    public int AtkRange
    {
        get { return atkRange; }
        set { atkRange = value; }
    }
    public string Fraction
    {
        get { return fraction; }
        set { fraction = value; }
    }
    public string UName
    {
        get { return uName; }
        set { uName = value; }
    }

    //methods
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void PosClosestUnit()
    {
        //for loop running through the list to determine the closest unit
        foreach (GameObject gObj in gm.units)
        {
            //pythag determining distance between a unit and onther.
            double r = System.Math.Sqrt((gObj.transform.position.x * this.transform.position.x) + (gObj.transform.position.y * this.transform.position.y));
            //if the distance is smaller than the next smallest distnce
            if (r < distance)
            {
                // set the closest unit distance and ...
                closX = gObj.transform.position.x;
                closY = gObj.transform.position.y;
                cX = System.Convert.ToInt32(closX);
                cY = System.Convert.ToInt32(closY);
                // ... set that distance to the smallest distance
                distance = System.Convert.ToInt32(r);
            }
        }
        //then check to see if the target is in range
        CanAttack();
    }
    public override void Attack()
    {
        target = new Vector2(closX, closY);
        if (CanAttack())
        {
            // changing the health of the opponents 
            //units[cUindex].GetComponentsInParent <GameObject> hP = units[cUindex].GetComponentsInParent <GameObject> hP - atk;
            float step = (1 + speed) * Time.deltaTime;
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, target, step);

        }
        else
        {
            float step = (1 + speed) * Time.deltaTime;
            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, target, step);
        }
        Death();
    }
    public override bool CanAttack()
    {
        if (distance <= atkRange)
        {
            return true;
        }
        else return false;
    }
    public override void Death()
    {
        //try this to remove a unit
        //int i = units.FindIndex();
        units.Remove(gm);
    }
    public override string ToString()
    {
        string str = "str";
        //str = "Melee Unit" + Environment.NewLine + "Name: " + UName + Environment.NewLine + "Team: " + fraction + Environment.NewLine + "(" + xPos + "," + yPos + ")" + Environment.NewLine + "Health: " + hP + Environment.NewLine + "Attack: " + atk + Environment.NewLine + "Speed: " + speed;
        return str;
    }
}
