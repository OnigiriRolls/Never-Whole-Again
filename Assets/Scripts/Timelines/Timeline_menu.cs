using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_menu : MonoBehaviour
{
    private bool fix = false;
    public PlayableDirector director;
    public GameObject menu;

    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
            menu.SetActive(true);
           
        }
    }

}
