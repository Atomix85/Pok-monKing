using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Capacity : ICloneable
{

    string name;
    int power;
    int pp;
    int accuracy;
    static public Capacity[] defaultCapacities;

    public static void initCapacities()
    {
        defaultCapacities = new Capacity[1];
        defaultCapacities[0] = new AncientPower();
    }
    public Capacity(string name, int power, int pp, int accuracy)
    {
        this.accuracy = accuracy;
        this.name = name;
        this.power = power;
        this.pp = pp;
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public virtual void use(Pokemon emit,Pokemon target)
    {
        pp--;
    }
}
