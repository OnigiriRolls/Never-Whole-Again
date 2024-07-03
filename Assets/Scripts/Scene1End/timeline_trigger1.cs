using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class timeline_trigger1 : MonoBehaviour
{
    public GameObject timeline;
    public bool state;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
            state = true;
    }

    private void Update()
    {
        if (state==true && GlobalManager.Instance.timelineBreak==true)
        {
            timeline.GetComponent<PlayableDirector>().enabled = true;
            timeline.GetComponent<Timeline_run_away>().enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
            state = false;
    }
}
