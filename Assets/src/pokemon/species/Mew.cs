using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mew : Pokemon, IPsyType
{

    public Mew(int level) : base("mew", level)
    {
        this.name = "Mew";
        setBaseStats();
        setIV();
        setStats();

        capacities[0] = CapacitiesRef.ancientPower.Clone() as Capacity ;
        resistance = EfficientRule.basicTablePsy;
    }

    void setBaseStats()
    {
        baseStats = new Stats();
        baseStats.Pv = 100;
        baseStats.Attack = 100;
        baseStats.Defense = 100;
        baseStats.SpeAttack = 100;
        baseStats.SpeDefense = 100;
        baseStats.Vitess = 100;
    }
}
