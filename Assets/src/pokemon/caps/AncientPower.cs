using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AncientPower : Capacity {

	public AncientPower() : base("Pouv.Antique", 60, 5,100)
    {

    }
    public override void use(Pokemon emit,Pokemon target)
    {
        base.use(emit, target);
        target.setPv(target.getPv() - 2);

    }
}
