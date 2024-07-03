using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragNDrop_blue : MonoBehaviour ,IDragHandler, IEndDragHandler
{

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        GlobalManager.Instance.R5_press = false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        GlobalManager.Instance.R5_press = true;  
    transform.localPosition = Vector3.zero;        
    }
   
}
