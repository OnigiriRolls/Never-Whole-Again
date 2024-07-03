using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Timeline_Manager_Trap : MonoBehaviour
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
    public GameObject timePanel;
    
    public GameObject cam;
    public GameObject inv;

    public GameObject[] triggers;

    void OnEnable()
    {    
        girlAnim = girlAnimator.runtimeAnimatorController;
        girlAnimator.runtimeAnimatorController = null;
        boyAnim = boyAnimator.runtimeAnimatorController;
        boyAnimator.runtimeAnimatorController = null;
        
        inv.SetActive(false);
        girl.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        for (int i = 0; i < triggers.Length; i++)
            triggers[i].gameObject.SetActive(false);

    }



    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
         
            cam.GetComponent<CameraController>().player = boy.transform;
            boy.GetComponent<Movement1>().enabled = true;
            girlAnimator.runtimeAnimatorController = girlAnim;
            boyAnimator.runtimeAnimatorController = boyAnim;
            girlAnimator.SetBool("trap", true);
            boy.transform.position = pos;
            girl.transform.position = pos1;
            girl.tag = "Player";
            boy.tag = "Player1";
            boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            boy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            timePanel.SetActive(true);
        }
    }

}
