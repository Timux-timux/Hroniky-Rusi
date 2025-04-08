using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialog : MonoBehaviour
{
    public static bool EndDialog = false;
    public GameObject Cube;
    public GameObject Dialog1;
    public CharacterController cc;
    public GameObject Quest;
    public GameObject NextNPC;



    void Start()
    {
        
    }


    void Update()
    {
        if(EndDialog == true)
        {
            cc.enabled = true;
            Cube.SetActive(false);
            Dialog1.SetActive(false);
            Quest.SetActive(true);
            NextNPC.SetActive(true);
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player" )
        {

            Time.timeScale = 0;

            Dialog1.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }


    }



}
