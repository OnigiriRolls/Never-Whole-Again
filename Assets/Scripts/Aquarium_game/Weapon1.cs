using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bullet;
    public float speed;
    public float timer;
    float angle;
    public float min;
    public float max;

    void Start()
    {
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        angle = Random.Range(min, max);
        firePoint.rotation = Quaternion.Euler(0, 0, angle);
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce((-1) * firePoint.right * speed);
        yield return new WaitForSeconds(timer);
        StartCoroutine(Time());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
