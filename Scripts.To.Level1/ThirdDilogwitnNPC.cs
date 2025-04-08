using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;using UnityEngine.Cursor.Visible;

public class ThirdDilogwitnNPC : MonoBehaviour
{
   
    public GameObject TextB1;
    public GameObject TextB2;
    public GameObject TextB31;
    public GameObject TextB32;
    public GameObject TextB4;
    public GameObject TextB5;
    public GameObject Answers;
    public GameObject Guys;
    public GameObject QuestGuys;

    public void Start()
    {
    
    }
  


   public void ButtonCliced()
    {
        TextB1.SetActive(false);
        TextB2.SetActive(true);
        Answers.SetActive(true);
    }
    public void Abswer1Clicked()
    {
        Answers.SetActive(false);
        TextB2.SetActive(false);
        TextB31.SetActive(true);
        AllInts.TrueAnswers++;
    }
    public void Abswer2Clicked()
    {
        Answers.SetActive(false);
        TextB2.SetActive(false);
        TextB32.SetActive(true);
        
    }
    public void Abswer3Clicked()
    {
        Answers.SetActive(false);
        TextB2.SetActive(false);
        TextB32.SetActive(true);
    }
    public void ButtonCliced2()
    {
        TextB31.SetActive(false);
        TextB32.SetActive(false);
        TextB5.SetActive(true);
    }
    public void ButtonCliced3()
    {
        NPS_Dilog2.isEnd = true;
        Guys.SetActive(true);
        QuestGuys.SetActive(true);
    }
}
