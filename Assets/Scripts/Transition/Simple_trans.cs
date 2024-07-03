using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Simple_trans : MonoBehaviour
{
    public string sceneToLoad;
   
   

   public void Go()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


    

}
