using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Anim : MonoBehaviour
{
    public PlayableDirector director;
    bool state;


    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.tag=="Player1" )
        {
            state = true;
            
        }
    }

    private void Update()
    {
        if(state && Input.GetKeyDown(KeyCode.E))
        {
            director.GetComponent<PlayableDirector>().enabled = true;
            director.GetComponent<Timeline_aquarium>().enabled = true;
            state = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        state = false;
    }
}
