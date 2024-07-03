using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Shooter : MonoBehaviour
{
   
  //  public float timer;
    public float timerStart;
    public GameObject []waves;//care val vine
    public float [] times;//cat dureaza fiecare
    public float[] pauses;//pauza dintre intervale
    public int[] change;//la care wave incepe Teea
    public float[] timesTeea;
    public GameObject[] bullets;
    int i;
    int j;
  
    public GameObject fish;
    Third_wave thirdWave;
    public Animator teeaAnim;
    public GameObject bossAdmin;
    Restart_3rdWave bossWave;
   

   
    public GameObject timeline;

    void Start()
    {
        bossWave = bossAdmin.GetComponent<Restart_3rdWave>();
        thirdWave = fish.GetComponent<Third_wave>();
        i = 0;
        j = 0;
        StartCoroutine("StartTime");
    }

    IEnumerator Timer()
    {
        if (i < waves.Length)
        {
           
           if(i==2||i==4||i==6||i==11)
            {
                waves[i].SetActive(true);
                while (GlobalManager.Instance.bigFish == false)
                    yield return null;            
                waves[i].SetActive(false);
                yield return new WaitForSeconds(pauses[i]);          
                GlobalManager.Instance.bigFish = false;
                bossWave.Restart();

            } 
           else
            {
                waves[i].SetActive(true);
                yield return new WaitForSeconds(times[i]);
                waves[i].SetActive(false);
                yield return new WaitForSeconds(pauses[i]);
            }

            if (j < change.Length)
            {
                
                if (i == change[j])
                {
                    if (j == 1||j==7)
                    {
                        if (j == 7)
                            GlobalManager.Instance.j7 = true;
                        thirdWave.Change();
                        bullets[j].SetActive(true);
                        teeaAnim.SetTrigger("front");
                        while (GlobalManager.Instance.exit == false)
                            yield return null;
                       // bullets[j].SetActive(false);
                        j++;
                        // thirdWave.restart();
                       
                        if (GlobalManager.Instance.end_on == false && j==8)
                        {       
                            fish.SetActive(false);
                            GlobalManager.Instance.noHealth = true;
                            timeline.GetComponent<PlayableDirector>().enabled = true;
                            timeline.GetComponent<Timeline_bad_ending>().enabled = true;
                            StopAllCoroutines();
                        }

                        GlobalManager.Instance.exit = false;
                    }
                    else if(i==5)
                    {//5 directii
                        bullets[j].SetActive(true);
                        yield return new WaitForSeconds(timesTeea[j]);
                        bullets[j].SetActive(false);
                        j++;

                        //anim
                        thirdWave.Change();
                        bullets[j].SetActive(true);
                        teeaAnim.SetTrigger("front");
                        while (GlobalManager.Instance.exit == false)
                            yield return null;
                      //  bullets[j].SetActive(false);
                        j++;
                     //   thirdWave.restart();
                       
                        GlobalManager.Instance.exit = false;

                    }
                    else if(i==8)
                    {
                        thirdWave.Change();
                        //anim
                        bullets[j].SetActive(true);
                        teeaAnim.SetTrigger("front");
                        while (GlobalManager.Instance.exit == false)
                            yield return null;
                       // bullets[j].SetActive(false);
                        j++;
                    //thirdWave.restart();
                        
                        GlobalManager.Instance.exit = false;

                        yield return new WaitForSeconds(1.5f);
                        //5 directii
                        bullets[j].SetActive(true);
                        yield return new WaitForSeconds(timesTeea[j]);
                        bullets[j].SetActive(false);
                        j++;
                    }
                    else
                    {
                        bullets[j].SetActive(true);
                        yield return new WaitForSeconds(timesTeea[j]);
                        bullets[j].SetActive(false);
                        j++;
                    }
                  
                }
            }
            i++;
            if(i<waves.Length)
            StartCoroutine("Timer");
        }
       
    }

    IEnumerator StartTime()
    {
        yield return new WaitForSeconds(timerStart);
        StartCoroutine("Timer");
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
