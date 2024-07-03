using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HorizontalMove : MonoBehaviour
{
    Vector2 move;
  
    public GameObject upperMeasure;
    public GameObject lowerMeasure;

    public int number;
    public int squares;
   public float upperOffset;
    public float lowerOffset;
    public int line;
    public GameObject[] lines;
    public int[] cubes;

    public Game_Master dataScript;

    public bool drag;


    private void Start()
    {
        
        if (this.transform.rotation.z != 0)
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
        
            dataScript.NohighlightAll();
            drag = true;
            dataScript.PresentLocationHorizontal(number, line);
            dataScript.HighlightHorizontal(cubes, line, number);     

    }

    public void Update()
    {
        if (drag== true && dataScript.index != -1 && dataScript.pressed==number)
            {
               
                move = transform.localPosition;
                for (int i = 0; i <= 5; i++)
                    if (cubes[i] == dataScript.index)
                    {
                      
                        int transCube = 0;
                        transCube = 6 - i;

                        if (transCube < dataScript.start)
                        {
                            
                            dataScript.NohighlightHorizontal(cubes, line, number);
                            move.x = lines[transCube - 1].transform.localPosition.x + Mathf.Abs(lowerOffset);
                            dataScript.UpdateHorizontal(number, transCube, transCube + squares - 1, line);
                            transform.localPosition = move;
                        }
                        else if (transCube > dataScript.end)
                        {
                             
                            dataScript.NohighlightHorizontal(cubes, line, number);
                            move.x = lines[transCube].transform.localPosition.x - Mathf.Abs(upperOffset);
                            dataScript.UpdateHorizontal(number, transCube - squares + 1, transCube, line);
                            transform.localPosition = move;
                        }
                        dataScript.Check_Key();
                        //dataScript.WriteArray();
                        dataScript.index = -1;
                       
                        drag = false;
                        break;
                    }

            }
          
        }
    }


