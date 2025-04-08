using UnityEngine;

public class DilogScene1Level3 : MonoBehaviour
{

    public GameObject Gon;
    public GameObject Kn;
    public GameObject ThisDilog;
    public GameObject MainCamera;
    public GameObject NPCCamera;
    public GameObject NPC;


    public GameObject Gon1;
    public GameObject Gon2;
    public GameObject Gon3;

    public GameObject Kn1;
    public GameObject Kn2;

    public GameObject Kn3;
    public GameObject Kn32;

    public GameObject Kn4;

    public GameObject Kn5;
    public GameObject Kn6;
    
    public GameObject Kn7;

    public GameObject Kn8;

    public GameObject Audio1;
    public GameObject Audio2;

    private void Start()
    {
        Escepe.isDilog = true;
    }

    public void OnButtonClick()
    {
        Gon1.SetActive(false);
        Gon.SetActive(false);
        Kn.SetActive(true);
        Kn1.SetActive(true);
        

    }

    public void OnButtonCLick2()
    {
        Kn3.SetActive(false);
        Kn32.SetActive(true);
    }

    public void OnButtonClick3()
    {
        Kn32.SetActive(false);
        Kn2.SetActive(true);
    }
   

    public void OnButtonClick4()
    {
        Kn.SetActive(false) ;
        Kn2.SetActive(false);
        Gon.SetActive(true);
        Gon2.SetActive(true);

    }
    public void OnButtonClick5()
    {
        Gon.SetActive(false);
        Gon2.SetActive(false);
        Kn.SetActive(true);
        Kn4.SetActive(true);
    }

    public void OnButtonClick6()
    {
        Kn5.SetActive(false);
        Kn6.SetActive(true);
    }
    public void OnbuttonClick7()
    {
        Kn7.SetActive(false);
        Kn5.SetActive(true);
    }
    public void OnbuttonClick8()
    {
        Kn6.SetActive(false);
        Kn8.SetActive(true);
    }

    public void OnbuttonClick9()
    {
        Kn8.SetActive(false);
        Kn.SetActive(false);
        Gon.SetActive(true);
        Gon3.SetActive(true);

    }


    public void EndDilog()
    {
        ThisDilog.SetActive(false);
        Time.timeScale = 1;
        NPCCamera.SetActive(false);
        MainCamera.SetActive(true);
        NPC.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
     
        Cursor.visible = false;
        Escepe.isDilog = false;
    }



    public void FirstRightAnswer()
    {
        Kn2.SetActive(true);
        Kn1.SetActive(false);
        AllIntsLevel3.TrueAnswers++;
    }

    public void FirstUnRightAnswer()
    {
        Kn1.SetActive(false);
        Kn3.SetActive(true);
    }




    public void SecendTrueAnswer()
    {
        Kn4.SetActive(false);
        Kn5.SetActive(true);
        AllIntsLevel3.TrueAnswers++;
    }

    public void SecendUnTrueAnswer()
    {
        Kn4.SetActive(false);
        Kn7.SetActive(true);
    }



}
