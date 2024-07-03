using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class Ending_Transition : MonoBehaviour
{
    private bool fix = false;
    public PlayableDirector director;
    public GameObject obj;

    public string sceneToLoad;   
    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float fadeWait;


    private void Awake()
    {
        if (fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }


    public IEnumerator FadeCo()
    {

        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);

        }

        yield return new WaitForSeconds(fadeWait);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);

        while (!asyncOperation.isDone)
        {
            yield return null;
        }

    }


    private void Update()
    {
        if (director.state != PlayState.Playing && !fix && obj.GetComponent<Ending>().state==true &&GlobalManager.Instance.screwdriver_taken==true)
        {
            Debug.Log(director.state);
            fix = true;      
            StartCoroutine(FadeCo());
        }
    }
}
