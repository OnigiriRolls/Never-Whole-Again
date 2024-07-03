using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IDragHandler,IEndDragHandler
{

    public void OnDrag(PointerEventData eventData)
    {

        if (this.gameObject.name.Equals("Paper_Button(Clone)"))
            if (this.GetComponent<Sign_Awake_Button>().dialogBox1.activeSelf == true)
                this.GetComponent<Sign_Awake_Button>().dialogBox1.SetActive(false);
        transform.position = Input.mousePosition;
        GlobalManager.Instance.R5_press = false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("Paper_Button(Clone)"))
            if (this.GetComponent<Sign_Awake_Button>().dialogBox1.activeSelf == true)
                this.GetComponent<Sign_Awake_Button>().dialogBox1.SetActive(false);
        GlobalManager.Instance.R5_press = true;
        transform.localPosition = Vector3.zero;
    }
}
