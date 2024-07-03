using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jhin_attack : MonoBehaviour
{
    public GameObject teea;
    R1_Simple_Sign script;
    public float dmg;

    private void Start()
    {
        script = teea.GetComponent<R1_Simple_Sign>();
    
    }

    void Update()
    {
        if(script.state==true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("merge");
            teea.GetComponent<Teea_health>().health= teea.GetComponent<Teea_health>().health - dmg;
        }
    }
}
