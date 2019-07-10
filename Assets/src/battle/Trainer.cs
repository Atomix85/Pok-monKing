using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : Team {

    public Trainer(string name) : base(name)
    {
        
    }
    public override void updateBattle(GameObject obj)
    {
        base.updateBattle(obj);
        if (obj.transform.position.x <= 6)
        {
            obj.transform.Translate(Time.deltaTime * 10f, 0f, 0f);
        }
    }
}
