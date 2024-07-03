using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Camera_timeline : MonoBehaviour
{
    private bool fix = false;
    public GameObject camObject;
    public Animator cam;
    public RuntimeAnimatorController camAnim;
    public PlayableDirector director;
   // public Vector3 pos;
    public GameObject boy;
    public GameObject[] triggers;
   
    void OnEnable()
    {
        boy.tag = "Player";
        camObject.GetComponent<Animator>().enabled = true;
        camAnim= cam.runtimeAnimatorController;
        cam.runtimeAnimatorController = null;
  
    }

    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
            cam.runtimeAnimatorController = camAnim;
            camObject.GetComponent<Animator>().enabled = false;
         //   camObject.transform.position = pos;
            for (int i = 0; i < triggers.Length; i++)
                triggers[i].gameObject.SetActive(true);
        }
    }
  
 
}
