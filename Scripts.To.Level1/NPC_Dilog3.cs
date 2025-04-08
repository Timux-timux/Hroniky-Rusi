using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dilog3 : MonoBehaviour
{
    public GameObject Dilog;
    void Start()
    {

    }

    
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        Time.timeScale = 0;
        Dilog.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
