using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Character_deactivate : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject character;

    void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector && character.gameObject!=null)
            character.SetActive(false);
    }

    void OnDisable()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }
}
