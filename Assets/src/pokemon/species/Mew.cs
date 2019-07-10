using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mew : PsyType
{

    public Mew(int level) : base("mew", level)
    {
        setBaseStats();
        setIV();
        setStats();

        capacities[0] = Capacity.defaultCapacities[0].Clone() as Capacity ;
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
