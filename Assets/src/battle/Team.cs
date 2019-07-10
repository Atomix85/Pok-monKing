using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team {

    string name;
    Pokemon[] pokemons;
    int nbPokemonInTeam;

    public Team(string name){
        this.name = name;
        nbPokemonInTeam = 0;
        pokemons = new Pokemon[6];
    }
    public int addPokemon(Pokemon pokemon)
    {
        if(nbPokemonInTeam < 6)
        {
            pokemons[nbPokemonInTeam] = pokemon;
            nbPokemonInTeam++;
        }
        return 0;
    }
    public Pokemon getFirstAlivePokemon()
    {
        foreach(Pokemon pokemon in pokemons){
            
            if( pokemon != null && pokemon.getPv() > 0)
            {
                return pokemon;
            }
        }
        return null; // Aucun pokemon vivant = gameover
    }
    public virtual void updateBattle(GameObject obj)
    {
        
    }

}
