using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VerticalMove : MonoBehaviour
{
    Vector2 move;
   
    public GameObject upperMeasure;
    public GameObject lowerMeasure;

    public int number;
    public int squares;
   public float upperOffset;
   public  float lowerOffset;
    public int column;
    public GameObject[] lines;
    public int[] cubes;

    public Game_Master dataScript;

    public bool drag;
    

    private void Start()
    {
        if (transform.rotation.z == 0)
        {
            upperOffset = upperMeasure.transform.localPosition.y;
            lowerOffset = lowerMeasure.transform.localPosition.y;
        }
        else
        {
            upperOffset = upperMeasure.transform.localPosition.x;
            lowerOffset = lowerMeasure.transform.localPosition.x;
        }
    }

    public void Check()
    {
        dataScript.pressed = number;
        Debug.Log(dataScript.pressed);
        dataScript.NohighlightAll();      
            drag = true;
            dataScript.HighlightVertical(cubes, column,number);
            dataScript.PresentLocationVertical(number, column);
    }

    public void Update()
    {
        if (drag &&dataScript.index!=-1 && dataScript.pressed==number)
        {  
            move = transform.localPosition;
            for (int i = 0; i <= 5; i++)
                if (cubes[i] == dataScript.index)
                {
                 

                    if (i + 1 < dataScript.start)
                    {
                        dataScript.NohighlightVertical(cubes, column,number);
                        move.y = lines[i].transform.localPosition.y - Mathf.Abs(upperOffset);
                        dataScript.UpdateVertical(number, i + 1, i + squares, column);
                        transform.localPosition = move;
                        Debug.Log("sus "+(i + 1) + (i + squares));
                    }
                    else if (i + 1 > dataScript.end)
                    {
                        dataScript.NohighlightVertical(cubes, column,number);
                        move.y = lines[i + 1].transform.localPosition.y + Mathf.Abs(lowerOffset);
                        dataScript.UpdateVertical(number, i - squares + 2, i + 1, column);
                        transform.localPosition = move;
                        Debug.Log("jos " + (i - squares + 2) + (i + 1));
                    }
                    dataScript.index = -1;
                    
                    drag = false;
                    break;
                }
           
        }

    }
}
