using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_break : MonoBehaviour
{
    private bool fix = false;
    public GameObject boy;
    public Animator boyAnimator;
    public RuntimeAnimatorController boyAnim;

    public Animator doorAnimator;
    public RuntimeAnimatorController doorAnim;

    public PlayableDirector director;

 
    public GameObject bulletDoor;
    public GameObject trigger;

    void OnEnable()
    {
        
        boyAnim = boyAnimator.runtimeAnimatorController;
        boyAnimator.runtimeAnimatorController = null;
        doorAnim = doorAnimator.runtimeAnimatorController;
        doorAnimator.runtimeAnimatorController = null;
        boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        bulletDoor.SetActive(true);
        trigger.SetActive(false);
    }

    private void Update()
    {
        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
            boyAnimator.runtimeAnimatorController = boyAnim;
            doorAnimator.runtimeAnimatorController = doorAnim;
            doorAnimator.SetBool("with", true);
            bulletDoor.SetActive(false);
            GlobalManager.Instance.timelineBreak = true;
            boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }

}
