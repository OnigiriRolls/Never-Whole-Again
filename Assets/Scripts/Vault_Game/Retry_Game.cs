using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry_Game : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject sign;
    VaultInventory Vault_inv;
    public GameObject Vault_ob;

    private void Start()
    {
        Vault_inv = Vault_ob.GetComponent<VaultInventory>();
    }

    public void Empty_Slots()
    {
        Destroy(slot1.transform.GetChild(0).gameObject);
        Destroy(slot2.transform.GetChild(0).gameObject);
        Destroy(slot3.transform.GetChild(0).gameObject);
        Destroy(slot4.transform.GetChild(0).gameObject);
        for (int i = 0; i < Vault_inv.isfull.Length; i++)
            Vault_inv.isfull[i] = false;
        sign.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
