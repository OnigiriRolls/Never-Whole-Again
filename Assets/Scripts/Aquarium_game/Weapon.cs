using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    
    public GameObject bullet;
    public float speed;
    public float timer;
   
    void OnEnable()
    {
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        Instantiate(bullet, firePoint.position,firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce((-1) * firePoint.right * speed);
        yield return new WaitForSeconds(timer);
        StartCoroutine(Time());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
