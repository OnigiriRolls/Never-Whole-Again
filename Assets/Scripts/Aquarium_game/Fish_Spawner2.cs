using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Spawner2 : MonoBehaviour
{
    GameObject clone;
    public float minTime;
    public float maxTime;
   float timer;
    public GameObject toSpawn;
    
    private void OnEnable()
    {
       
        timer = Random.Range(minTime, maxTime);
        StartCoroutine("Spawn");
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timer);
        clone = Instantiate(toSpawn, this.transform.position, Quaternion.identity);
        timer = Random.Range(minTime, maxTime);
        StartCoroutine("Spawn");
    }
   

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
