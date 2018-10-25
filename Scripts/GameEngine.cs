using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEngine : GameObject {

    string team1Name = "team1";
    string team2Name = "team2";
    int T1mUnitnum1 = 5;
    int T1mUnitnum2 = 5;
    int T1rUnitnum1 = 5;
    int T1rUnitnum2 = 5;

    int T2mUnitnum1 = 5;
    int T2mUnitnum2 = 5;
    int T2rUnitnum1 = 5;
    int T2rUnitnum2 = 5;

    // list that stores each unit
    public List<GameObject> units = new List<GameObject>();

    //this will be used to allocate a prefab to each unit
    public Slug s1 = new Slug();
    public Slug s2 = new Slug();
    public Axel a1 = new Axel();
    public Axel a2 = new Axel();
    public Pablito p1 = new Pablito();
    public Pablito p2 = new Pablito();
    public BoomBoomGuy Boom1 = new BoomBoomGuy();
    public BoomBoomGuy Boom2 = new BoomBoomGuy();

    public int T1MUnitnum1
    {
        get { return T1mUnitnum1; }
        set { T1mUnitnum1 = value; }
    }
    public int T1MUnitnum2
    {
        get { return T1mUnitnum2; }
        set { T1mUnitnum2 = value; }
    }
    public int T1RUnitnum1
    {
        get { return T1rUnitnum1; }
        set { T1rUnitnum1 = value; }
    }
    public int T1RUnitnum2
    {
        get { return T1rUnitnum2; }
        set { T1rUnitnum2 = value; }
    }
    public int T2MUnitnum1
    {
        get { return T2mUnitnum1; }
        set { T2mUnitnum1 = value; }
    }
    public int T2MUnitnum2
    {
        get { return T2mUnitnum2; }
        set { T1mUnitnum2 = value; }
    }
    public int T2RUnitnum1
    {
        get { return T2rUnitnum1; }
        set { T2rUnitnum1 = value; }
    }
    public int T2RUnitnum2
    {
        get { return T2rUnitnum2; }
        set { T2rUnitnum2 = value; }
    }

    //generates units and buildng randomly
    public void GenerateUnits()
    {
        //team 1 units
        // This populates the map with melee unit one, slugs
        for (int i = 0; i < T1mUnitnum1; i++)
        {
            //fix the random
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            Vector2 temp = new Vector2(x, y);
            s1.UName = "Slug";
            s1.transform.position = temp;
            s1.Fraction = team1Name;
            units.Add(s1);

        }
        // This populates the map with melee unit two, swordman
        for (int i = 0; i < T1mUnitnum2; i++)
        {
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            //sets the x and y pos using a temporary cordinates
            Vector2 temp = new Vector2(x, y);
            a1.transform.position = temp;
            a1.UName = "Axel";
            a1.Fraction = team1Name;
            units.Add(a1);
           
        }
        // This populates the map with ranged Unit one, rifleman
        for (int i = 0; i < T1rUnitnum1; i++)
        {
            //fix the random
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            Vector2 temp = new Vector2(x, y);
            p1.transform.position = temp;
            p1.UName = "Pablitos";
            p1.Fraction = team1Name;
            units.Add(p1);
        }
        // This populates the map with ranged Unit two, missile launcher
        for (int i = 0; i < T1rUnitnum2; i++)
        {
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            Vector2 temp = new Vector2(x, y);
            Boom1.transform.position = temp;
            Boom1.UName = "Boom Boom Guy";
            Boom1.Fraction = team1Name;
            units.Add(Boom1);
        }

        //team 2units
        // This populates the map with melee unit one, slugs
        for (int i = 0; i < T2mUnitnum1; i++)
        {
            //fix the random
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            Vector2 temp = new Vector2(x, y);
            s2.UName = "Slug";
            s2.transform.position = temp;
            s2.Fraction = team1Name;
            units.Add(s2);
        }
        //This populates the map with melee unit two, swordman
        for (int i = 0; i < T2mUnitnum2; i++)
        {
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            //sets the x and y pos using a temporary cordinates
            Vector2 temp = new Vector2(x, y);
            a2.transform.position = temp;
            a2.UName = "Axel";
            a2.Fraction = team1Name;
            units.Add(a2);
        }
        // This populates the map with ranged Unit one, rifleman
        for (int i = 0; i < T2rUnitnum1; i++)
        {
            //fix the random
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            Vector2 temp = new Vector2(x, y);
            p2.transform.position = temp;
            p2.UName = "Pablitos";
            p2.Fraction = team1Name;
            units.Add(p2);
        }
        //This populates the map with ranged Unit two, missile launcher
        for (int i = 0; i < T2rUnitnum2; i++)
        {
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            System.Random rnd2 = new System.Random(Guid.NewGuid().GetHashCode());
            int x = rnd.Next(0, 20);
            int y = rnd2.Next(0, 20);
            Vector2 temp = new Vector2(x, y);
            Boom2.transform.position = temp;
            Boom2.UName = "Boom Boom Guy";
            Boom2.Fraction = team1Name;
            units.Add(Boom2);
        }
        
        
    }

    //place units
    
    // This Method saves the units
    public void Save()
    {
        //string FileName = @"D:\\RTS_Map.txt";
        //BinaryFormatter formatter = new BinaryFormatter();
        //Stream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
        //formatter.Serialize(stream, arrPb.ToString());
        //stream.Close();
    }

    // This method read/ loads the units
    public void Read()
    {
        //string FileName = @"D:\\RTS_Map.txt";
        //BinaryFormatter formatter = new BinaryFormatter();
        //Stream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
        //formatter.Deserialize(stream);
        //stream.Close();
        //placeUnits();

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
