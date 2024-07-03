using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//l am adaugat special pt scene
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float fadeWait;

    public GameObject trigger;

    private void Awake()
    {
        if (fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
        
        
    }

    private void OnMouseDown()
    {
        if (trigger.GetComponent<R1_Simple_Sign>().state==true)
        {    
            playerStorage.initialValue = playerPosition;
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
