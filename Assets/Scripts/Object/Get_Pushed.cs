using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Pushed : MonoBehaviour
{
    public float speed;

    void Start()
    {
        this.GetComponent<Rigidbody2D>().isKinematic=true;
        if (GlobalManager.Instance.dresser_pos!=Vector3.zero)
        this.transform.position = GlobalManager.Instance.dresser_pos;
    }

    private void Update()
    {
        if(this.GetComponent<FixedJoint2D>().enabled==false)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().isKinematic = true;
        }
        else
        {
            GlobalManager.Instance.dresser_pos = this.transform.position;
        }
    }
}
