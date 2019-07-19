using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growl : Capacity,INormalType {

    public Growl() : base("Rugissement", -1, 40, 100) 
    {

    }
    public override void use(Pokemon emit, Pokemon target)
    {
        base.use(emit, target);
        Debug.Log(target.getStats().Attack);
        target.getStats().Attack = (int)(target.getStats().Attack * 2.0f / 3.0f);
        Debug.Log(target.getStats().Attack);
    }

}
