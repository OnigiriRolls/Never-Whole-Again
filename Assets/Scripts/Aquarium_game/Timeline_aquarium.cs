using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_aquarium : MonoBehaviour
{
    private bool fix = false;

    public Animator girlAnimator;
    public Animator boyAnimator;
    public RuntimeAnimatorController girlAnim;
    public RuntimeAnimatorController boyAnim;
    public PlayableDirector director;

    public GameObject boy;
    public GameObject girl;
    public Vector2 pos;

    public GameObject gameManager;
    public GameObject wave;
    public GameObject fish;

    public GameObject transTrigger;
    public GameObject refillArea;
    public GameObject arm;

    void OnEnable()
    {
        GlobalManager.Instance.end_on = true;
        girlAnim = girlAnimator.runtimeAnimatorController;
        girlAnimator.runtimeAnimatorController = null;
        boyAnim = boyAnimator.runtimeAnimatorController;
        boyAnimator.runtimeAnimatorController = null;
        gameManager.GetComponent<Shooter>().StopAllCoroutines();
        gameManager.SetActive(false);
         wave.SetActive(false);
        if (fish.activeSelf == true)
            fish.SetActive(false);
        fish.SetActive(false);
       
        arm.SetActive(false);
    }


    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            boy.transform.position = pos;
            fix = true;
            GlobalManager.Instance.end = true;
            girlAnimator.runtimeAnimatorController = girlAnim;
            boyAnimator.runtimeAnimatorController = boyAnim;
            boy.transform.position = pos;
            girl.SetActive(false);

           
            boyAnimator.SetBool("swim", false);
            boyAnimator.SetBool("teea", true);
            transTrigger.SetActive(true);
            refillArea.GetComponent<Animator>().SetBool("idle", true);
         
        }
    }
}
