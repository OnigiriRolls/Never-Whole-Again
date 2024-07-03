using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEffect : MonoBehaviour
{

    public ParticleSystem ps;
    void Start()
    {
        ps.Play();
    }

    private void OnDisable()
    {
        if(ps.isPlaying)
        ps.Stop();
    }


}
