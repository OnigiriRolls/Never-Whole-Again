using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_behaviour : StateMachineBehaviour
{
   
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(stateInfo.normalizedTime>=1)
        {
            animator.SetTrigger("exit");
        }
    }

   
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    
}
