using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Timeline_Manager_r1 : MonoBehaviour
{

    private bool fix = false;
   
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
        if(girlAnim!=null)
           
        girlAnimator.runtimeAnimatorController = null;
        boyAnim = boyAnimator.runtimeAnimatorController;
        boyAnimator.runtimeAnimatorController = null;
    }



    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
            girl.transform.position = pos1;
            girlAnimator.runtimeAnimatorController = girlAnim;
            boyAnimator.runtimeAnimatorController = boyAnim;         
            boy.GetComponent<Boy_Animate>().enabled = true;
        }
    }
}
