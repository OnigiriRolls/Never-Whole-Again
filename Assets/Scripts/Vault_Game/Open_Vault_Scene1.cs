using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Vault_Scene1 : MonoBehaviour
{
    public bool state;
    public GameObject ob;
    private void Start()
    {
        
        state = GlobalManager.Instance.vaultState;
        if (state == true)
        {
            ob.gameObject.SetActive(true);
            
        }
    }
}
