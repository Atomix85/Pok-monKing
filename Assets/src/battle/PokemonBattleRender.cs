using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBattleRender {

	public static void makeSprite(GameObject terrain, Pokemon pokemon,bool reversed)
    {
        SpriteRenderer sr;

        GameObject pokemonObject;

        pokemonObject = terrain.transform.
            Find("Combat-pokemon").gameObject;

        if (pokemonObject != null)
        {

            sr = pokemonObject.GetComponent<SpriteRenderer>();

            if (reversed)
            {
                sr.sprite = pokemon.getBackSprite();
            }
            else
            {
                sr.sprite = pokemon.getFrontSprite();
            }

            GameObject life = terrain.transform.Find("PV_TEXT").gameObject;

            life.GetComponent<TextMesh>().text = "PV "+pokemon.getPv()+"/" + pokemon.getStats().Pv;
        }
    }
}
