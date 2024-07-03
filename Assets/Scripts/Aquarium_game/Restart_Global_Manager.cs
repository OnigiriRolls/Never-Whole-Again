using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart_Global_Manager : MonoBehaviour
{
    private void OnEnable()
    {
        GlobalManager.Instance.exit = false;
        GlobalManager.Instance.end_on = false;
        GlobalManager.Instance.bigFish = false;
        GlobalManager.Instance.end = false;
        GlobalManager.Instance.noHealth = false;
        GlobalManager.Instance.j7 = false;
    }
}
