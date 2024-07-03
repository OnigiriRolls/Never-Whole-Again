using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_vault : MonoBehaviour
{
    public GameObject panel;

    public GameObject number;
    public GameObject obj;
    VaultInventory vaultInv;
    GameObject copy;


    private void Start()
    {
        vaultInv = obj.GetComponent<VaultInventory>();
    }

    public void SpawnNumber()
    {
        if (GlobalManager.Instance.nr == 5)

        {
            for (int i = 0; i < vaultInv.slots.Length; i++)
            {
                if (vaultInv.isfull[i] == false)
                {
                    vaultInv.isfull[i] = true;
                    copy = Instantiate(number, vaultInv.slots[i].transform, false);
                    copy.transform.position = vaultInv.slots[i].transform.position;
                    break;
                }
            }
        }
        else panel.SetActive(true);

    }
}
