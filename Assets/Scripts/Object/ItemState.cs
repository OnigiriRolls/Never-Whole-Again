using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemState : MonoBehaviour
{
    public Vector2 Position;
    public bool active;
    GlobalManager glm;

    private void Awake()
    { 
        active = false;
        /*/
       if (Position.x == 0 && Position.y == 0)
        {
            Position.x = this.GetComponent<Spawn>().item.GetComponent<Transform>().position.x;
            Position.y = this.GetComponent<Spawn>().item.GetComponent<Transform>().position.y;
        }
       /*/
    }
    public void Activate()
    {
        active = !active;
    }
}
