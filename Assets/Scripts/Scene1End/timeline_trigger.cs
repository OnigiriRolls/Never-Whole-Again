using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timeline_trigger : MonoBehaviour
{
    public GameObject timeline;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            timeline.GetComponent<PlayableDirector>().enabled = true;
            timeline.GetComponent<Timeline_break>().enabled = true;
        }
    }
}
