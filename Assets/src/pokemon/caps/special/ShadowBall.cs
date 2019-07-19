using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBall : Capacity, IGhostType
{

    public ShadowBall() : base("Ball'Ombre", 80, 15, 100)
    {

    }
    public override void use(Pokemon emit, Pokemon target)
    {
        base.use(emit, target);

        int SpeAttack = emit.getStats().SpeAttack;
        int SpeDefense = target.getStats().SpeDefense;
        int degat = makeDegat(emit.getLevel(), this.power, SpeAttack, SpeDefense, calculateCM(target));
        target.setPv(target.getPv() - degat);
    }
}
