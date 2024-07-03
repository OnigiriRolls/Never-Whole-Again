using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_run_away : MonoBehaviour
{
    private bool fix = false;
    public GameObject boy;
    public Animator boyAnimator;
   
    public RuntimeAnimatorController boyAnim;
    public PlayableDirector director;

    public GameObject panel;
    public GameObject trigger;

    void OnEnable()
    {
        
        boyAnim = boyAnimator.runtimeAnimatorController;
        boyAnimator.runtimeAnimatorController = null;
        boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        trigger.SetActive(false);
    }

    private void Update()
    {
        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;       
            boyAnimator.runtimeAnimatorController = boyAnim;
            panel.SetActive(true);
        }
    }

}
