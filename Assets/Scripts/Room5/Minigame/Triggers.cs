using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public Game_Master game;
    public int nr;

    public void Index()
    {
        game.index = nr;
    }

}
