using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject Trigger;







    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtinClickedRestartLevel()
    {
        
        Time.timeScale = 0;
        NPC1.SetActive(true);
        NPC3.SetActive(false);
        Trigger.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
}
