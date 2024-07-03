using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_Manager_cut : MonoBehaviour
{
    private bool fix = false;
 //   public Vector3 pos;
   // public Vector3 pos1;
    public GameObject girl;
    public GameObject boy;
    public Animator girlAnimator;
    public Animator boyAnimator;
    public RuntimeAnimatorController girlAnim;
    public RuntimeAnimatorController boyAnim;
    public PlayableDirector director;

    //public GameObject cam;
 //   public Animator camAnimator;
   // public RuntimeAnimatorController camAnim;

    //public GameObject triggerToActivate;
    public GameObject inv;
    public GameObject trap;
   
    public GameObject panel;
    

    void OnEnable()
    {
        inv.SetActive(false);
    //    cam.GetComponent<Animator>().enabled = true;
      //  camAnim = camAnimator.runtimeAnimatorController;
     //   camAnimator.runtimeAnimatorController = null;
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
           // camAnimator.runtimeAnimatorController = camAnim;
           // cam.GetComponent<Animator>().enabled = false;
            //cam.GetComponent<CameraController>().player = boy.transform;

          //  girlAnimator.runtimeAnimatorController = girlAnim;
            boyAnimator.runtimeAnimatorController = boyAnim;
           // boy.transform.position = pos;
            
            inv.SetActive(true);
           
           
           // cam.GetComponent<Animator>().enabled = false;
            girl.SetActive(false);
            trap.SetActive(true);
            panel.SetActive(false);
           // triggerToActivate.GetComponent<BoxCollider2D>().enabled = true;
            this.enabled = false;

            //  girl.transform.position = pos1;
        }
    }
}
