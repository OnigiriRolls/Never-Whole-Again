using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Trap_anim : MonoBehaviour
{
    public GameObject timeline;
    int i = 0;
    public GameObject triggerPanel;



    private void Update()
    {       

        if ( i == 0 && triggerPanel.GetComponent<InSquare>().stateGirl==true)
        {
            i++;
        timeline.GetComponent<PlayableDirector>().enabled = true;
            timeline.GetComponent<Timeline_Manager_Trap>().enabled = true;
            Destroy(this.gameObject);


        }
    }
   
}
