using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Struggle : Capacity,INormalType {
    public Struggle() : base("Lutte", 50, -1, -1)
    {

    }
    public override void use(Pokemon emit, Pokemon target)
    {
        base.use(emit, target);

        int attack = emit.getStats().Attack;
        int defense = target.getStats().Defense;
        int degat = makeDegat(emit.getLevel(), this.power, attack, defense, 1.0f);
        target.setPv(target.getPv() - degat);
        emit.setPv(emit.getPv() - degat / 2);
    }
}
