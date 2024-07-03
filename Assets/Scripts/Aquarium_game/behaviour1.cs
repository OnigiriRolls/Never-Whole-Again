using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class behaviour1 : StateMachineBehaviour
{

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
            if (s == "right" && GlobalManager.Instance.j7 == true)
            {
                if (GlobalManager.Instance.end_on == false)
                {
                    GlobalManager.Instance.exit = true;
                    animator.SetTrigger("exit");
                }

            }
            else
                animator.SetTrigger(s);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        
            

    }

    
}
