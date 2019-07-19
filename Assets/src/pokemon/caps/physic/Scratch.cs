using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scratch : Capacity,INormalType {

    public Scratch() : base("Griffe", 40, 35, 100)
    {

    }
    public override void use(Pokemon emit, Pokemon target)
    {
        base.use(emit, target);

        int Attack = emit.getStats().Attack;
        int Defense = target.getStats().Defense;
        int degat = makeDegat(emit.getLevel(), this.power, Attack, Defense, calculateCM(target));
        target.setPv(target.getPv() - degat);
    }
}
