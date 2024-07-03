using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behaviour2 : StateMachineBehaviour
{
    float time;
    public string s;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.normalizedTime >= 1)
        {
            
            GlobalManager.Instance.exit = true;
        animator.SetTrigger(s);
           
        }
       
    }

   

  
}
