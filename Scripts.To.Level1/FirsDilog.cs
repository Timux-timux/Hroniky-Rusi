using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirsDilog : MonoBehaviour
{

    public GameObject Dialog;
    public GameObject Text1;
    public GameObject Text2;
    public static bool  isQuest = false;
    public  GameObject Quest;
    public GameObject Window;
    public GameObject Cibe;


    void Start()
    {
        
        Time.timeScale = 0;
        Dialog.SetActive(true);
        Text1.SetActive(true);


    }


    public void ButtonClicked()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    public void ButtonClicked2()
    {   Cibe.SetActive(false);
        Text2.SetActive(false);
        Time.timeScale = 1;
        Dialog.SetActive(false);
        Quest.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }
}

