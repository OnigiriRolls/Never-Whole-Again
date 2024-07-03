using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timeline_trans : MonoBehaviour
{
    private bool fix = false;
    public PlayableDirector director;

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

    private void Update()
    {

        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
            StartCoroutine(FadeCo());

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

}
