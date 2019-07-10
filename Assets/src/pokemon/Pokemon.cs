﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon {
    protected Stats stats;
    protected Stats baseStats;
    protected Stats IV;
    protected float nature;
    protected int level;
    protected int life;

    public Capacity[] capacities;

    protected Sprite frontSprite, backSprite;

    public void kill()
    {
        this.life = 0;
    }
    public int getPv()
    {
        return life;
    }
    public void setPv(int life)
    {
        this.life = life;
    }

    public Stats getStats()
    {
        return stats;
    }

    public Sprite getFrontSprite()
    {
        return frontSprite;
    }
    public Sprite getBackSprite()
    {
        return backSprite;
    }
    
    public Pokemon(string spriteName, int level)
    {
        this.level = level;
        this.nature = 1.0f;
        this.capacities = new Capacity[4];
        frontSprite = Resources.Load("graphics/pokemon/" + spriteName + "/front", typeof(Sprite)) as Sprite;
        backSprite = Resources.Load("graphics/pokemon/" + spriteName + "/back", typeof(Sprite)) as Sprite;
    }
    protected void setStats()
    {
        stats = new Stats();
        stats.Attack = (int)( ( (2 * baseStats.Attack + IV.Attack + level)/100 + 5 ) * nature );
        stats.Defense = (int)(((2 * baseStats.Defense + IV.Defense + level) / 100 + 5) * nature);
        stats.SpeAttack = (int)(((2 * baseStats.SpeAttack + IV.SpeAttack + level) / 100 + 5) * nature);
        stats.SpeDefense = (int)(((2 * baseStats.SpeDefense + IV.SpeDefense + level) / 100 + 5) * nature);
        stats.Vitess = (int)(((2 * baseStats.Vitess + IV.Vitess + level) / 100 + 5) * nature);
        stats.Pv = (int)((2 * baseStats.Vitess + IV.Vitess + level) / 100 + level + 10);

        stats.Attack = (int)(((IV.Attack + baseStats.Attack)*2*level)/100+5);
        stats.Defense = (int)(((IV.Defense + baseStats.Defense) * 2 * level) / 100 + 5);
        stats.SpeAttack = (int)(((IV.SpeAttack + baseStats.SpeAttack) * 2 * level) / 100 + 5);
        stats.SpeDefense = (int)(((IV.SpeDefense + baseStats.SpeDefense) * 2 * level) / 100 + 5);
        stats.Vitess = (int)(((IV.Vitess + baseStats.Vitess) * 2 * level) / 100 + 5);
        stats.Pv = (int)(((IV.Pv + baseStats.Pv) * 2 * level) / 100) + level+10;

        life = stats.Pv;
    }
    protected void setIV()
    {
        IV = new Stats();
        IV.Attack = Random.Range(0, 15);
        IV.SpeAttack = Random.Range(0, 15);
        IV.Defense = Random.Range(0, 15);
        IV.SpeDefense = IV.SpeAttack;
        IV.Vitess = Random.Range(0, 15);
        IV.Pv = 8 * (IV.Attack % 2 == 0 ? 0 : 1) + 
            4*(IV.Defense  % 2 == 0 ? 0 : 1) +
            2*(IV.Vitess % 2 == 0 ? 0 : 1) +
            (IV.SpeAttack % 2 == 0 ? 0 : 1);
    }
}