using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDialogwithNPC : MonoBehaviour
{
 
    public GameObject Bo;
    public GameObject TextB1;
    public GameObject TextB2;
    public GameObject TextK;
    public GameObject TextB3;
    public GameObject TextB4;
    public GameObject TextB51;
    public GameObject TextB52;
    public GameObject TextB6;
    public GameObject Answers;




    void Start()
    {

    }
    public void ButtonCLiced()
    {
        TextB1.SetActive(false);
        TextB2.SetActive(true);
    }
    public void ButtonClicked2()
    {
        TextB2.SetActive(false);
        Bo.SetActive(false);
        TextK.SetActive(true);
    }
    public void ButtonClicked3()
    {
        TextK.SetActive(false);
        Bo.SetActive(true);
        TextB3.SetActive(true);
    }
    public void ButtonClicked4()
    {
        TextB3.SetActive(false);
        TextB4.SetActive(true);
        Answers.SetActive(true);
    }
    public void ButtonClickedTrueAnswer()
    {
        TextB4.SetActive(false);
        Answers.SetActive(false);
        TextB51.SetActive(true);
        AllInts.TrueAnswers++;
    }
    public void ButtonClickedUnTrueAnswer()
    {
        TextB4.SetActive(false);
        Answers.SetActive(false);
        TextB52.SetActive(true);
    }
    public void ButtonClicked5()
    {
        TextB52.SetActive(false);
        TextB51.SetActive(false);
        TextB6.SetActive(true);
    }
    public void ButtonClicked6()
    {
        TextB6.SetActive(false);
        NPC_Dialog.EndDialog = true;
        NPS_Dilog2.isEnd = false;
    }


}
