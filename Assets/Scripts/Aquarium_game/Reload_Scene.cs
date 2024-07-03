using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload_Scene : MonoBehaviour
{

    public string scene;

    public void Reload()
    {
      
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }
    

}
