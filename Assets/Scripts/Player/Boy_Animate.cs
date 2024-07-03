using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Boy_Animate : MonoBehaviour
{
   // private int i = 0;
    public Vector3 pos;
    public Animator boyanim;
/*/
    public PlayableDirector director;

    void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector && i == 0)
        {
            Debug.Log(this.transform.position);
            this.transform.position = pos;
            Debug.Log(this.transform.position);
            i++;
        }
    }

    void OnDisable()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }/*/
    void Start()
    {
       
        boyanim.SetBool("work", true);
        this.transform.position = pos;
    }
    
    
}
