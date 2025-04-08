using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DilogWithGonez : MonoBehaviour
{

    public GameObject ThisDilog;
    public GameObject Gon;
    public GameObject Gon1;
    public GameObject Gon2;
    public GameObject Answers;
    public GameObject Gon31;
    public GameObject Gon32;
    public GameObject GonEnd;
    public GameObject AN;
    public GameObject AN1;
    public GameObject AN2;
    public GameObject MainCamera;
    public GameObject NPC_Camera;
    public GameObject Trigger;
    public GameObject Cube;

    public void OnButtonClicked()
    {
        Gon1.SetActive(false);
        Gon2.SetActive(true);
        Answers.SetActive(true);
    }

    public void OnButtonClickedRightAnswer()
    {
        Answers.SetActive(false);
        Gon2.SetActive(false);
        Gon31.SetActive(true);
        AllIntsLevel2.TrueAnswers++;
    }
    public void OnButtonClickedNotRightAnswer()
    {
        Answers.SetActive(false);
        Gon2.SetActive(false);
        Gon32.SetActive(true);
        AllIntsLevel2.TrueAnswers++;
    }
    public void OnButtonClicked2()
    {
        Gon.SetActive(false);
        Gon32.SetActive(false);
        Gon31.SetActive(false);
        AN.SetActive(true);
    }
    public void OnButtonClicked3()
    {
        AN1.SetActive(false);
        AN2.SetActive(true);
    }
    public void OnButtonClicked4()
    {
        AN.SetActive(false);
        Gon.SetActive(true);
        GonEnd.SetActive(true);
    }
    public void OnButtonClicked5()
    {
        ThisDilog.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        MainCamera.SetActive(true);
        NPC_Camera.SetActive(false);
        Trigger.SetActive(false);
        Cube.SetActive(false);
    }

}
