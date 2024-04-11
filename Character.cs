using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;


        public Character()
        {
        Reset();
        }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.name, this.exp);
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }

}

public class Paladin : Character
{
    public Weapon weapon;

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.name, this.weapon.name);
    }

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }
}