using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Spawner : MonoBehaviour
{
    GameObject clone;
   // public float minTime;
   // public float maxTime;
    public float timer;
    public GameObject toSpawn;
    public float delayTime;

    private void OnEnable()
    { 
        StartCoroutine(Delay());
    }

  IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timer);
        clone = Instantiate(toSpawn, this.transform.position, Quaternion.identity);
        StartCoroutine("Spawn");
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTime);
        StartCoroutine("Spawn");
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
