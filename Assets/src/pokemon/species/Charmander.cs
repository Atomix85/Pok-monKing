using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : FireType {
    
    public Charmander(int level) : base("charmander", level)
    {

        setBaseStats();
        setIV();
        setStats();

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
