using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool [] isfull;//cu vectorul asta tin minte daca un slot din inventar e liber sau nu(slot[i]==true->ocupat)
    // slot[i]=false->nu e ocupat
    public GameObject[] slots;//in vectorul asta punem obiectul oarecum:)) trebe sa ti arat
    //ca de fapt nu bagam in vector obiectul, ci il atasam, il legam de slot
    //aici doar declaram astea si le atasam la jucator, sa aiba acolo inventar
}
