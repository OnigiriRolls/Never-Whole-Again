using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vault_retry_game : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;

    public GameObject sign;

    VaultInventory Vault_inv;
    public GameObject Vault_ob;

    private void Start()
    {
        Vault_inv = Vault_ob.GetComponent<VaultInventory>();
    }

    public void Retry()
    {
        if(slot1.transform.childCount>0)
        Destroy(slot1.transform.GetChild(0).gameObject);
        if (slot2.transform.childCount > 0)
            Destroy(slot2.transform.GetChild(0).gameObject);
        if (slot3.transform.childCount > 0)
            Destroy(slot3.transform.GetChild(0).gameObject);
        if (slot4.transform.childCount > 0)
            Destroy(slot4.transform.GetChild(0).gameObject);
        if (slot5.transform.childCount > 0)
            Destroy(slot5.transform.GetChild(0).gameObject);
        if (slot6.transform.childCount > 0)
            Destroy(slot6.transform.GetChild(0).gameObject);

        for (int i = 0; i < Vault_inv.isfull.Length; i++)
            Vault_inv.isfull[i] = false;

        sign.SetActive(false);
       
    }
}
