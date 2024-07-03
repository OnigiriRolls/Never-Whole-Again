using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InSquare : MonoBehaviour
{
    public Transform min;
    public Transform max;

    public Transform girl;
    public Transform boy;
    public bool stateGirl;
    public bool stateBoy;

    void Update()
    {
        if (girl.position.x < max.position.x && girl.position.y < max.position.y &&
            girl.position.x > min.position.x && girl.position.y > min.position.y)
        {
            stateGirl = true;
           
        }
        else stateGirl = false;
        if (boy.position.x < max.position.x && boy.position.y < max.position.y &&
            boy.position.x > min.position.x && boy.position.y > min.position.y)
        {
            stateBoy = true;
           
        }
        else stateBoy = false;
    }
}
