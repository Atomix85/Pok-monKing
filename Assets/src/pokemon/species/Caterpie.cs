using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caterpie : InsectType
{

    public Caterpie(int level) : base("caterpie", level)
    {
        setBaseStats();
        setIV();
        setStats();


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
