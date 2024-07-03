using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CameraController : MonoBehaviour
{
    public Transform player;
    public float smoothing;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    public GameObject min;
    public GameObject max;
    public GameObject CamMin;
    public GameObject CamMax;

    private void Start()
    {
        minPosition.x = min.transform.position.x+Mathf.Abs (CamMin.transform.localPosition.x);
        minPosition.y = min.transform.position.y + Mathf.Abs(CamMin.transform.localPosition.y);
        maxPosition.x = max.transform.position.x-Mathf.Abs( CamMax.transform.localPosition.x);
        maxPosition.y = max.transform.position.y - Mathf.Abs(CamMax.transform.localPosition.y);
    }


/*/
    private void Update()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), 
            new Vector3(0, 0, 1));
        for (int i = 0; i < hits.Length; i++)
            if (hits[i].collider != null)
                Debug.Log(hits[i].collider.name);

    }
    /*/
    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if(transform.position!=player.position)
        {

            Vector3 targetpos = new Vector3(player.position.x, player.position.y, transform.position.z);
            targetpos.x = Mathf.Clamp(targetpos.x, minPosition.x, maxPosition.x);
            targetpos.y = Mathf.Clamp(targetpos.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetpos, smoothing);
        }
        
    }
   

}
