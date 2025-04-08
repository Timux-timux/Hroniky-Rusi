using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthDilogwithNPC : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Dilog;
    public GameObject image;
    public GameObject Audio;
    public GameObject Quest;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    public void ButtonCloiked2()
    {
        Dilog.SetActive(false);
        image.SetActive(true);
        Quest.SetActive(false);
        Audio.SetActive(true);
        NPC_Dialog.EndDialog = false;

    }

}
