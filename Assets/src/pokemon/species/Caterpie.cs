using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caterpie : Pokemon,IInsectType
{

    public Caterpie(int level) : base("caterpie", level)
    {
        this.name = "Chenipan";
        setBaseStats();
        setIV();
        setStats();
        capacities[0] = CapacitiesRef.tackle.Clone() as Capacity;
        resistance = EfficientRule.basicTableInsect;
    }

    void setBaseStats()
    {
        baseStats = new Stats();
        baseStats.Pv = 45;
        baseStats.Attack = 30;
        baseStats.Defense = 35;
        baseStats.SpeAttack = 20;
        baseStats.SpeDefense = 20;
        baseStats.Vitess = 45;
    }
}
