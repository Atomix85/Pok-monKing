using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {
    public GameObject adversaireTerrain;
    public GameObject meTerrain;

    Terrain terrain;

    // Use this for initialization
    void Start () {

        Trainer trainer = new Trainer("pute");
        PlayerTeam player = new PlayerTeam("Red");
        Capacity.initCapacities();

        player.addPokemon(new Mew(70));
        //trainer.addPokemon(new Caterpie(50));
        trainer.addPokemon(new Caterpie(3));

        player.getFirstAlivePokemon().capacities[0].use(
            player.getFirstAlivePokemon(), trainer.getFirstAlivePokemon());

        terrain = new Terrain(trainer,player);
        Terrain.playerPart = meTerrain;
        Terrain.trainerPart = adversaireTerrain;

        terrain.callPokemon();
        

    }
	
	// Update is called once per frame
	void Update () {

        terrain.update();

    }
}
