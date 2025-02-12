﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon, IFireType {
    
    public Charmander(int level) : base("charmander", level)
    {
        this.name = "Salamèche";
        setBaseStats();
        setIV();
        setStats();
        capacities[0] = CapacitiesRef.growl.Clone() as Capacity;
        capacities[1] = CapacitiesRef.scratch.Clone() as Capacity;
        capacities[2] = CapacitiesRef.ember.Clone() as Capacity;
        resistance = EfficientRule.basicTableFire;
    }
   
    void setBaseStats()
    {
        baseStats = new Stats();
        baseStats.Pv = 39;
        baseStats.Attack = 52;
        baseStats.Defense = 43;
        baseStats.SpeAttack = 60;
        baseStats.SpeDefense = 50;
        baseStats.Vitess = 65;
    }
}
