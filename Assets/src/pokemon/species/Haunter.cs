using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haunter : Pokemon,IGhostType, IPoisonType {

    public Haunter(int level) : base("haunter", level)
    {
        this.name = "Spectrum";
        setBaseStats();
        setIV();
        setStats();
        capacities[0] = CapacitiesRef.shadowBall.Clone() as Capacity;
        resistance = EfficientRule.calculateDoubleType(
            EfficientRule.basicTableGhost,
            EfficientRule.basicTablePoison);
    }

    void setBaseStats()
    {
        baseStats = new Stats();
        baseStats.Pv = 45;
        baseStats.Attack = 50;
        baseStats.Defense = 45;
        baseStats.SpeAttack = 115;
        baseStats.SpeDefense = 55;
        baseStats.Vitess = 95;
    }

}
