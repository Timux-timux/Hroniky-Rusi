using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiloWitnTM : MonoBehaviour
{

    public GameObject ThisDilog;
    public GameObject AN;
    public GameObject TM;
    public GameObject AN1;
    public GameObject AN2;
    public GameObject AN3;
    public GameObject AN4;
    public GameObject TM1;
    public GameObject TM2;
    public GameObject TM31;public GameObject TM32;
    public GameObject TM4;
    public GameObject TM5;
    public GameObject TM6;public GameObject Trigger;

    
    public GameObject MainCamera;
    public GameObject NPC;


    public Text InputText;
    [SerializeField] public InputField inputFiled;
    [SerializeField] public string MText;




    public void SaveInputText()
    {
        MText = InputText.text;
        ChecingToAnswer();
    }

    public void ChecingToAnswer()
    {
        if (MText == "1242")
        { TrueAnswer();
             }
        else
           UnTrueAnswer();
    }


    public void OnButtonClicked()
    {
        TM.SetActive(false);
        AN.SetActive(true);
    }
    public void OnButtonClicked2()
    {
        AN.SetActive(false);
        TM.SetActive(true);
        TM1.SetActive(false);
        TM2.SetActive(true);
    }
    public void TrueAnswer()
    {
        TM2.SetActive(false);
        TM31.SetActive(true);
        AllIntsLevel2.TrueAnswers++;
    }
    public void UnTrueAnswer()
    {
        TM2.SetActive(false);
        TM32.SetActive(true);
    }
    public void OnButtonClicked3()
    {
        TM32.SetActive(false);TM31.SetActive(false);
        TM4.SetActive(true);
    }
    public void OnButtonClicked4()
    {
        TM4.SetActive(false);
        TM.SetActive(false);
        AN.SetActive(true);
        AN1.SetActive(false);
        AN2.SetActive(true);
    }
    public void OnButtonClicked5()
    {
        AN2.SetActive(false);
        AN3.SetActive(true);
    }
    public void OnButtonClicked6()
    {
        AN.SetActive(false);
        AN3.SetActive(false);
        TM.SetActive(true);
        TM5.SetActive(true);
    }
    public void OnButtonCLicked7()
    {
        TM5.SetActive(false);
        TM6.SetActive(true);
    }
    public void OnButtonClicked8()
    {
        MainCamera.SetActive(true);
        NPC.SetActive(false);
        TM6.SetActive(false);
        TM.SetActive(false);
        AN.SetActive(true);
        AN4.SetActive(true);
    }

    public void OnButtonClickedEnd()
    {
        Time.timeScale = 1;
        ThisDilog.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Trigger.SetActive(false);

    }














}
