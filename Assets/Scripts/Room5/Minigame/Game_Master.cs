using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Master : MonoBehaviour
{
    [SerializeField]
    public int[,] visited;
    [SerializeField]
    public float[,] position;
    public GameObject grid;

    public int index = -1;
    public int start = -1;
    public int end = -1;
    public int pressed;

    public GameObject trigger;
    public GameObject game;
    public GameObject toSpawn;
    public GameObject player;
    Inventory inv;
    Dontdestroy trans;
    GameObject copy;
    GameObject objectManager;

    private void Awake()
    {
        visited = new int[10,10];
        position = new float[40, 3];
        for(int i=0;i<=7;i++)
        {
            visited[i,0] = -1;
            visited[i,7] = -1;
            visited[0,i] = -1;
            visited[7,i] = -1;
        }

        visited[1,1] =1;
        visited[1,2]= 0;
        visited[1,3] =2;
        visited[1,4] = 3;
        visited[1,5] = 3;
        visited[1,6] = 3;
        visited[2,1] = 1;
        visited[2,2] = 0;
        visited[2,3] = 2;
        visited[2,4] = 4;
        visited[2,5] = 0;
        visited[2,6] = 0;
        visited[3,1] = 1;
        visited[3,2] = 10;
        visited[3,3] = 10;
        visited[3,4] = 4;
        visited[3,5] = 0;
        visited[3,6] = 9;
        visited[4,1] = 5;
        visited[4,2] = 5;
        visited[4,3] = 6;
        visited[4,4] = 6;
        visited[4,5] = 0;
        visited[4,6] = 9;
        visited[5,1] = 7;
        visited[5,2] = 7;
        visited[5,3] = 8;
        visited[5,4] = 8;
        visited[5,5] = 0;
        visited[5,6] = 9;
        visited[6,1] = 0;
        visited[6,2] = 0;
        visited[6,3] = 0;
        visited[6,4] = 0;
        visited[6,5] = 0;
        visited[6,6] = 0;  
    }

    private void Start()
    {
        inv = player.GetComponent<Inventory>();
        objectManager = GameObject.Find("TransitionItems");
        trans = objectManager.GetComponent<Dontdestroy>();
    }

    public void WriteArray()
    {
              
        for (int i = 1; i <= 6; i++)
        {   
                print(visited[i, 1] + " "+ visited[i, 2] + " "+ visited[i, 3] + " "+
                    visited[i, 4] + " "+ visited[i, 5] + " "+ visited[i, 6] + " ");         
        }
    }

    public void UpdateVertical(int number,int il,int sl,int column)
    {
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= 6; j++)
                if (visited[i, j] == number)
                    visited[i, j] = 0;
        }
        for (int i = il; i <= sl; i++)
            if(visited[i,column]==0)
            visited[i, column] = number;
    }

    public void UpdateHorizontal(int number, int il, int sl, int line)
    {
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= 6; j++)
                if (visited[i, j] == number)
                    visited[i, j] = 0;
        }
        for (int i = il; i <= sl; i++)
            if (visited[line,i] == 0)
                visited[line,i] = number;
    }
    public void HighlightVertical(int []cube,int line,int number)
    {
        int k = 0,st=0,en=0,i;
        for ( i = 1; i <= 6; i++)
            if (visited[i, line] == number)
            {
                if (k == 0)
                    st = i;
                en = i;
                k++;
            }

        i = en+1;
        while (visited[i, line] == 0 && i<=6)
        {
            grid.transform.GetChild(cube[i - 1]).gameObject.SetActive(true);
            i++;
           
        }
        i = st-1;
        while (visited[i, line] == 0 && i >=1)
        {
            grid.transform.GetChild(cube[i - 1]).gameObject.SetActive(true);
            i--;
           
        }
       
   
    }
    public void HighlightHorizontal(int[] cube, int line,int number)
    {

        int k = 0, st = 0, en = 0, i;
        for (i = 1; i <= 6; i++)
            if (visited[line, i] == number)
            {
                if (k == 0)
                    st = i;
                en = i;
                k++;
            }

        i = en+1;
        while (visited[line, i] == 0 && i <= 6)
        {
            grid.transform.GetChild(cube[6-i]).gameObject.SetActive(true);
            i++;
            
        }
        i = st-1;
    
        while (visited[line, i] == 0 && i >= 1)
        {
            grid.transform.GetChild(cube[6-i]).gameObject.SetActive(true);
            i--;
            
        }
        
    }
    public void NohighlightVertical(int[] cube, int line,int number)
    {

        for (int i = 1; i <= 6; i++)
            if (visited[i, line] == 0 || visited[i,line]==number)
                grid.transform.GetChild(cube[i - 1]).gameObject.SetActive(false);

    }
    public void NohighlightHorizontal(int[] cube, int line,int number)
    {

        for (int i = 1; i <= 6; i++)
            if (visited[line, i] == 0 || visited[line,i]==number)
                grid.transform.GetChild(cube[6-i]).gameObject.SetActive(false);

    }

    public void NohighlightAll()
    {

        for (int i = 0; i <=35; i++)
           if(grid.transform.GetChild(i).gameObject.activeSelf==true)
                grid.transform.GetChild(i).gameObject.SetActive(false);

    }


    public void PresentLocationVertical(int number,int line)
    {
        int k = 0;
        for(int i=1;i<=6;i++)
            if(visited[i,line]==number)
            {
                if (k == 0)
                    start = i;
                end = i;
                k++;
            }
    }

    public void PresentLocationHorizontal(int number, int line)
    {
        int k = 0;
        for (int i = 1; i <= 6; i++)
            if (visited[line, i] == number)
            {
                if (k == 0)
                    start = i;
                end = i;
                k++;
            }
    }

    public void Check_Key()
    {
        if(visited[3,6]==10 && visited [3,5]==10)
        {
            for (int i = 0; i < inv.slots.Length; i++)
                if (inv.isfull[i] == false)
                {
                    trans.full[i] = true;

                    inv.isfull[i] = true;

                    copy = Instantiate(toSpawn, inv.slots[i].transform, false);
                    Instantiate(toSpawn, objectManager.gameObject.transform, false);

                    copy.transform.position = inv.slots[i].transform.position;

                    Destroy(gameObject);

                    break;

                }

            GlobalManager.Instance.key_taken = true;
            trigger.SetActive(false);
            game.SetActive(false);
        }
    }

}
