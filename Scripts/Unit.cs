using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : GameEngine {

    //Fields
    protected int HP;
    protected int Speed;
    protected int Atk;
    protected int AtkRange;
    protected string Fraction;
    protected string Image;
    protected string uName;

    //Methods

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Unit()
    {
        //A constructor
    }

    public virtual void Attack()
    {
        //A method to handle combat with another unit
    }

    public virtual bool CanAttack()
    {
        //A method to determine whether another unit is within attack range
        return false;
    }

    public virtual void PosClosestUnit()
    {
        //A method to return position of the closest other unit to this unit
    }

    public virtual void Death()
    {
        //A method to handle the death of this unit
    }

    
}
