using UnityEngine;
using UnityEngine.UI;
public class DilogWithTMLevel3 : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject NPC_Camera;


    public GameObject ThisDilog
        ;

    public GameObject TriggerToDilog;


    public GameObject TM;
    public GameObject KN;

    public GameObject TM1;
    public GameObject KN1;

    public GameObject KN2;
    public GameObject TM2;

    public GameObject KN3;
    public GameObject TM3;

    public GameObject KN4;

    public GameObject TrueAnswerReaction;
    public GameObject TM4;
    public GameObject TM5;
    public GameObject TM6;

    public GameObject FalseAnswerReaction;

    [SerializeField] public TMPro.TMP_InputField inputField;
    [SerializeField] public string MText;

    public GameObject Audio;
    public GameObject Audio2;

    private void Start()
    {
        Escepe.isDilog = true;
    }

    public void ActiveKN()
    {
        KN.SetActive(true);
        TM.SetActive(false);
    }

    public void ActiveTM()
    {
        KN.SetActive(false);
        TM.SetActive(true);
    }

    public void OnButtonClick()
    {
        TM.SetActive(false);
        TM1.SetActive(false);
        KN.SetActive(true);
        KN1.SetActive(true);
        //Audio.SetActive(true);
       // Audio.SetActive(false);
    }

    public void OnButtonCLick2()
    {
        ActiveTM();
        KN1.SetActive(false);
        TM2.SetActive(true);
        Audio2.SetActive(true);
        Audio.SetActive(false);
    }

    public void OnButtonClick3()
    {
        TM2.SetActive(false);
        TM3.SetActive(true);
        Audio.SetActive(true);
        Audio2.SetActive(false);
    }



    public void OnButtonClick4()
    {
        ActiveKN();
        TM3.SetActive(false);
        KN2.SetActive(true);
        //Audio2.SetActive(true);
        Audio.SetActive(false);

    }

    public void SaveAnswer()
    {
        MText = inputField.text;
        ChecingAnswer();
    }

    public void ChecingAnswer()
    {
        if(MText == "1380")
        {
            ActiveTM();
            KN2.SetActive(false);
            TrueAnswerReaction.SetActive(true);
            Audio.SetActive(true);
            Audio2.SetActive(false);
            AllIntsLevel3.TrueAnswers++;
        }
        else
        {
            ActiveTM();
            KN2.SetActive(false);
            FalseAnswerReaction.SetActive(true);
            Audio.SetActive(true);
            Audio2.SetActive(false);
        }
    }

    public void TrueAnswer()
    {
        TrueAnswerReaction.SetActive(false);
        TM4.SetActive(true);
        Audio2.SetActive(true);
        Audio.SetActive(false);
    }

    public void FalseAnswer()
    {
        FalseAnswerReaction.SetActive(false);
        TrueAnswerReaction.SetActive(false);
        TM5.SetActive(true);
        Audio.SetActive(true);
       Audio2.SetActive(false);
    }

    public void FalseAnswer2()
    {
        TM4.SetActive(true);
        TM5.SetActive(false);
        Audio2.SetActive(true);
        Audio.SetActive(false);

    }
    public void OnButtonCLick5()
    {
        TM4.SetActive(false);
        TM6.SetActive(true);
        Audio.SetActive(true);
       Audio2.SetActive(false);
    }

    public GameObject TMcn;
    public void OnButtonCLick6()
    {
        ActiveKN();
        KN3.SetActive(true);
        MainCamera.SetActive(true);
        NPC_Camera.SetActive(false);
        Audio.SetActive(false);
        TMcn.SetActive(false);
    }
    public void OnButtonCLick7()
    {
        ThisDilog.SetActive(false );
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        TriggerToDilog.SetActive(false);
        Escepe.isDilog = false;
    }

    public void OnButtonClick8()
    {
        KN3.SetActive(false);
        KN4.SetActive(true);
    }
}
