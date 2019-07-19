using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfficientRule {

    static public EfficientRule basicTablePsy 
        = new EfficientRule(0.5f,2.0f,1.0f,
            1.0f,1.0f,1.0f,
            0.5f,2.0f);
    static public EfficientRule basicTableFire
        = new EfficientRule(1.0f, 0.5f, 0.5f,
            1.0f,2.0f,2.0f,
            1.0f,1.0f);
    static public EfficientRule basicTableInsect
        = new EfficientRule(1.0f, 1.0f, 2.0f,
            1.0f,2.0f,1.0f,
            1.0f,1.0f);
    static public EfficientRule basicTableNormal
        = new EfficientRule(1.0f, 1.0f, 1.0f,
            1.0f,1.0f,1.0f,
            1.0f,0.0f);
    static public EfficientRule basicTableRock
        = new EfficientRule(1.0f, 1.0f, 0.5f,
            0.5f,1.0f,2.0f,
            0.5f,1.0f);
    static public EfficientRule basicTableWater
        = new EfficientRule(1.0f, 1.0f, 0.5f,
            1.0f, 1.0f,0.5f,
            1.0f,1.0f);
    static public EfficientRule basicTablePoison
        = new EfficientRule(2.0f, 0.5f, 1.0f,
            1.0f, 1.0f, 1.0f,
            0.5f, 1.0f);
    static public EfficientRule basicTableGhost
        = new EfficientRule(1.0f, 0.5f, 1.0f,
            0.0f, 1.0f, 1.0f,
            0.5f, 2.0f);


    private float psy;
    private float insect;
    private float fire;
    private float normal;
    private float rock;
    private float water;
    private float ghost;
    private float poison;

    public EfficientRule(float psy, float insect, float fire,
        float normal,float rock, float water,
        float poison,float ghost)
    {
        this.psy = psy;
        this.insect = insect;
        this.fire = fire;
        this.normal = normal;
        this.rock = rock;
        this.water = water;
        this.ghost = ghost;
        this.poison = poison;
    }
    public float getEfficient(Capacity capacity)
    {
        float result;
        if (capacity is INormalType)
            result = this.normal;
        else if (capacity is IFireType)
            result = this.fire;
        else if (capacity is IPsyType)
            result = this.psy;
        else if (capacity is IInsectType)
            result = this.insect;
        else if (capacity is IRockType)
            result = this.rock;
        else if (capacity is IWaterType)
            result = this.water;
        else if (capacity is IPoisonType)
            result = this.poison;
        else if (capacity is IGhostType)
            result = this.ghost;
        else
            result = 1.0f;
        return result;
    }
    public static EfficientRule calculateDoubleType(EfficientRule type1,EfficientRule type2)
    {
        return new EfficientRule(type1.psy * type2.psy,
            type1.insect*type2.insect,
            type1.fire * type2.fire,
            type1.normal * type2.normal,
            type1.rock * type2.rock,
            type1.water * type2.water,
            type1.poison * type2.poison,
            type1.ghost * type2.ghost);
    }
}
