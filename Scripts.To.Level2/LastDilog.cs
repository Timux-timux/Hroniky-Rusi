using Unity.VisualScripting;
using UnityEngine;

public class LastDilog : MonoBehaviour
{
    public GameObject AN;
    public GameObject AN1;
    public GameObject AN2;
    public GameObject AN4;
    public GameObject AN5;
    public GameObject AN6;
    public GameObject AN7;
    public GameObject AN8;

    public GameObject G;
    public GameObject G1;
    public GameObject G2;

    public GameObject TheEnd;

    public GameObject ThisDilog;



    public int RightAnswers=0;



    public void OnButtonClick1()
    {
        AN1.SetActive(false); 
        AN2.SetActive(true);
    }

    public void OnButtonClickRightAnswer1()
    {   
        RightAnswers++;
        AllIntsLevel2.TrueAnswers++;
        AN2.SetActive(false);
        AN4.SetActive(true);
    }

    public void OnButtonClickUnRightAnswer1()
    {
        AN2.SetActive(false);
        AN4.SetActive(true);
    }



    public void OnButtonClickRightAnswer2()
    {
        RightAnswers++;
        AllIntsLevel2.TrueAnswers++;
        AN4.SetActive(false);
        AN5.SetActive(true);
    }

    public void OnButtonClickUnRightAnswer2()
    {
        AN4.SetActive(false);
        AN5.SetActive(true);
    }

    public void OnButtonClick2()
    {
        AN5.SetActive(false);
        AN6.SetActive(true);
    }

    public void OnButtonClickRightAnswer3()
    {
        RightAnswers++;
        AllIntsLevel2.TrueAnswers++;
        AN6.SetActive(false);
        AN7.SetActive(true);
    }

    public void OnButtonClickUnRightAnswer3()
    {
        AN6.SetActive(false);
        AN7.SetActive(true);
    }

    public void OnButtonClick3()
    {
        AN7.SetActive(false);
        AN8.SetActive(true);
    }

    public void OnButtonClick4()
    {
        AN.SetActive(false);
        G.SetActive(true);
        if(RightAnswers == 3)
        {
            G1.SetActive(true);
        }
        else G2.SetActive(true);


    }

    public void OnButtonClick5()
    {
        ThisDilog.SetActive(false);
        TheEnd.SetActive(true) ;




    }



}
