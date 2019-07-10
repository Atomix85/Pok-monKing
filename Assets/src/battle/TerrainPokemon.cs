using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain {

    static public GameObject playerPart, trainerPart;
    private Team adversaire, me;

    public Terrain(Trainer adversaire, PlayerTeam me)
    {
        this.adversaire = adversaire;
        this.me = me;
    }
    public void callPokemon()
    {
        Pokemon pokemonAdv = adversaire.getFirstAlivePokemon();
        Pokemon pokemonMe = me.getFirstAlivePokemon();

        if(pokemonAdv != null && pokemonMe != null)
        {
            PokemonBattleRender.makeSprite(playerPart, pokemonMe, true);
            PokemonBattleRender.makeSprite(trainerPart, pokemonAdv, false);

        }
    }
    public void update()
    {
        adversaire.updateBattle(trainerPart);
        me.updateBattle(playerPart);
    }
}
