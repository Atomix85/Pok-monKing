﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Capacity : ICloneable
{

    protected string name;
    protected int power;
    protected int pp;
    protected Type idType;
    protected int type;
    protected int accuracy;
    
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
    public static int makeDegat(int level, int power, int attack, int defense, float CM)
    {
        int result = 0;

        result = (int)( ( ( (0.4f * level + 2) * power * attack )/
            (50 * defense) + 2 ) * CM);

        return result;
    }

    public string getName()
    {
        return this.name;
    }

    public int getPP()
    {
        return pp;
    }

    public Color getColorCapacity()
    {
        if(this is IFireType)
        {
            return new Color(0.97f, 0.32f, 0.19f);
        }
        else if(this is INormalType)
        {
            return new Color(0.68f, 0.65f, 0.58f);
        }
        else if(this is IRockType)
        {
            return new Color(0.74f, 0.65f, 0.35f);
        }
        else if (this is IGhostType)
        {
            return new Color(0.39f, 0.39f, 0.71f);
        }
        return new Color(1.0F, 1.0f, 1.0f);
    }

    public float calculateCM(Pokemon target)
    {
        float result = target.resistance.getEfficient(this);
        if (result > 1.0f)
            Debug.Log("C'est super efficace !");
        else if(result == 0.0f)
        {
            Debug.Log("Ca n'a aucun effet...");
        }
        else if(result < 1.0f)
        {
            Debug.Log("Ce n'est très efficace...");
        }
        return result;
    }


    public virtual void use(Pokemon emit,Pokemon target)
    {
        Debug.Log(emit.getName() + " utilise " + name);
        pp--;
    }
}
