using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Inventory_Activate : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject inv;

    void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector && inv!=null)
            inv.gameObject.SetActive(true);
    }

    void OnDisable()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }
}
