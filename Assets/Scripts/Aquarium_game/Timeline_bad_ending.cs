using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_bad_ending : MonoBehaviour
{
    private bool fix = false;

    public Animator camAnimator;
    public Animator girlAnimator;
    public Animator boyAnimator;
    public RuntimeAnimatorController girlAnim;
    public RuntimeAnimatorController boyAnim;
    public RuntimeAnimatorController camAnim;
    public PlayableDirector director;

    public GameObject boy;

    public GameObject gameManager;
   
    
    public GameObject livesCanvas;
    
    public GameObject arm;
    public GameObject panel;

    void OnEnable()
    {
        girlAnim = girlAnimator.runtimeAnimatorController;
        girlAnimator.runtimeAnimatorController = null;
        boyAnim = boyAnimator.runtimeAnimatorController;
        boyAnimator.runtimeAnimatorController = null;
        camAnim = camAnimator.runtimeAnimatorController;
        camAnimator.runtimeAnimatorController = null;
        boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        gameManager.GetComponent<Shooter>().StopAllCoroutines();
        gameManager.SetActive(false);
    
        GlobalManager.Instance.end_on = true;
        arm.SetActive(false);
        boy.GetComponent<Jhin_Health>().air = 11;
        boy.GetComponent<Jhin_Health>().StopAllCoroutines();
        livesCanvas.SetActive(false);
    }


    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
            GlobalManager.Instance.end = true;
            girlAnimator.runtimeAnimatorController = girlAnim;
            boyAnimator.runtimeAnimatorController = boyAnim;
            camAnimator.runtimeAnimatorController = camAnim;
            panel.SetActive(true);
  
        }
    }
}
