using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapacitiesRef : MonoBehaviour {

    static public Capacity ancientPower;
    static public Capacity tackle;
    static public Capacity scratch;
    static public Capacity growl;
    static public Capacity struggle;
    static public Capacity ember;
    static public Capacity shadowBall;

    public static void initCapacities()
    {
        ancientPower = new AncientPower();
        tackle = new Tackle();
        scratch = new Scratch();
        growl = new Growl();
        struggle = new Struggle();
        ember = new Ember();
        shadowBall = new ShadowBall();
    }
}
