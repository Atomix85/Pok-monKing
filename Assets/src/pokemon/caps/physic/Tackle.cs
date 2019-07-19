using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tackle : Capacity,INormalType
{

    public Tackle() : base("Charge", 35, 35, 95)
    {

    }
    public override void use(Pokemon emit, Pokemon target)
    {
        base.use(emit, target);

        int attack = emit.getStats().Attack;
        int defense = target.getStats().Defense;
        int degat = makeDegat(emit.getLevel(), this.power, attack, defense, calculateCM(target));
        target.setPv(target.getPv() - degat);
    }
}

