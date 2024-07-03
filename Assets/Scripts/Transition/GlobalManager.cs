using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance;
    
  
    public bool R3_fill_trigger;
    public bool Recipient_empty;
    public bool Recipient_full;
    public int R3_Recipient_Index;
    public bool spawn_empty;
    public bool spawn_full;
   

    public bool paper_hit;
    public int  paper_index;
  //  public bool pressed_paper;
    public bool paper_picked;
    public bool code_active;

    public bool vaultState;
    public bool torch_taken;
    public bool R1_wd_trigger;
    public bool R1_above;
    public bool R1_vent_trigger;
    public float player_speed;
    public bool moving_object;
    public Vector3 dresser_pos;
    public bool drawer_on_trigger;
    public bool torch_end;
    public int torch_index;

    public bool R2_wd_trigger;
    public bool keyState;
    public bool R2_machine_trigger;
    public bool R2_Room4_Open;
    public bool screwdriver_taken;
    public int screwdriver_index;

    public bool R5_lock;
    public bool R5_press;
    public int R5_press_index;
    public bool R5_door_open;
    public bool movePiece;
    public bool inBoard;
    public bool key_taken;
    public int nr;
    public bool key_press;

    public bool exit;
    public bool end_on;
    public bool bigFish;
    public bool end;
    public bool noHealth;
    public bool j7;

    public bool timelineBreak;

    void Awake()
    {
        
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);         
            Instance = this;
        }
        else if (Instance != this)
        {         
            Destroy(gameObject);
        }
        
        
    }
}
