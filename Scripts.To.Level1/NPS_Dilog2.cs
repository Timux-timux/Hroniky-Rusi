using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS_Dilog2 : MonoBehaviour
{
    public CharacterController cc;
    public GameObject NPC;
    public GameObject Dilog;
   
    public static bool isEnd = false;

    void Start()
    {
        NPC.SetActive(false);
    }

 
    void Update()
    {
        if (isEnd)
        {
            Dilog.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            //cc.enabled = false;
            Time.timeScale = 0;
            Dilog.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
