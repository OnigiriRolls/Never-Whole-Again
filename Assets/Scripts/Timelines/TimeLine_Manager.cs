using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class TimeLine_Manager : MonoBehaviour
{
    private bool fix = false;
    public Vector3 pos;
    public Vector3 pos1;
    public GameObject girl;
    public GameObject boy;
    public Animator girlAnimator;
    public Animator boyAnimator;
    public RuntimeAnimatorController girlAnim;
    public RuntimeAnimatorController boyAnim;
    public PlayableDirector director;

    void OnEnable()
     {       
         girlAnim = girlAnimator.runtimeAnimatorController;
         girlAnimator.runtimeAnimatorController = null;
         boyAnim = boyAnimator.runtimeAnimatorController;
         boyAnimator.runtimeAnimatorController = null;
     }



     private void Update()
     {

         if (director.state != PlayState.Playing && !fix)
         {
             fix = true;

             girlAnimator.runtimeAnimatorController = girlAnim;
             boyAnimator.runtimeAnimatorController = boyAnim;
             boy.transform.position = pos;
             girl.transform.position = pos1;
         }
     }
 

}
