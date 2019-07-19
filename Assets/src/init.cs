using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {
    public GameObject adversaireTerrain;
    public GameObject meTerrain;

    Terrain terrain;
    Trainer trainer;
    PlayerTeam player;
    float timer = 0;
    // Use this for initialization
    void Start () {

        trainer = new Trainer("pute");
        player = new PlayerTeam("Red");
        CapacitiesRef.initCapacities();

        player.addPokemon(new Haunter(20));
        trainer.addPokemon(new Mew(100));
        trainer.addPokemon(new Caterpie(10));
        trainer.addPokemon(new Charmander(10));


        terrain = new Terrain(trainer,player);
        Terrain.playerPart = meTerrain;
        Terrain.trainerPart = adversaireTerrain;

    }
	
	// Update is called once per frame
	void Update () {

        terrain.update();
        if(timer > 2)
        {
            timer = 0;
            if(player.getFirstAlivePokemon() != null
                && trainer.getFirstAlivePokemon() != null)
            {
                player.getFirstAlivePokemon().useCapacity(-1, trainer.getFirstAlivePokemon());
                //trainer.getFirstAlivePokemon().useCapacity(-1, player.getFirstAlivePokemon());
            }
            
            terrain.callPokemon();
        }
        timer += Time.deltaTime;

    }
}
