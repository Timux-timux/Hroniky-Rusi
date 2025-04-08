using UnityEngine;
using System.Collections;
//using UnityEditor.Experimental.GraphView;
public class DilogWithRazv2 : MonoBehaviour
{
    public GameObject[] massive;

    public GameObject Knazz;
    public GameObject Razv;

    public Animator Black;
    public Animator Texttt;

    public GameObject BlackScreen;
    public GameObject TextToBlackScreen;

    int i;

    private void Start()
    {
        Escepe.isDilog = true;
        i = 0;
    }

    public void StartAnim()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        TextToBlackScreen.SetActive(true);
        BlackScreen.SetActive(true);
        StartCoroutine(Cid());
    }

    IEnumerator Cid()
    {
        Black.SetTrigger("Black");
        Texttt.SetTrigger("toBlack");
        yield return new WaitForSeconds(2);
        NextFraze();
        Black.SetTrigger("FronBlack");
        Texttt.SetTrigger("fromBlack");
        ToKnazz();
        yield return new WaitForSeconds(1);
        BlackScreen.SetActive(false);
        TextToBlackScreen.SetActive(false);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;


    }


    public GameObject False1;
    public GameObject False11;


    public void FalseAnswer1()

    {
        ToKnazz();
        massive[i].SetActive(false);
        False1.SetActive(true);
    }
    public void FalseAnswer11()
    {
        False1.SetActive(false);
        False11.SetActive(true);
    }
    public void FalseAnswer111()
    {

        i++;
        False11.SetActive(false);
        massive[i].SetActive(true);
        ToRazv();
    }

    public GameObject False2;
    public GameObject False22;

    public void FalseAnswer2()
    {
        ToKnazz();
        massive[i].SetActive(false);
        False2.SetActive(true);
    }
    public void FalseAnswer22()
    {
        False2.SetActive(false);
        False22.SetActive(true);
    }
    public void FalseAnswer222()
    {
        i++;
        False22.SetActive(false);
        massive[i].SetActive(true);
        Debug.Log(i);
        ToRazv();
    }





    public void NextFraze()
    {
        i++;
        if (i == 1)
            ToRazv();
        else if (i == 3)
            ToKnazz();
        else if (i == 4)
        {
            ToRazv();
            
            
        }
        if(i==5) AllIntsLevel3.TrueAnswers++;

        else if (i == 6)
        {
            ToRazv(); AllIntsLevel3.TrueAnswers++;
            
        }


        Debug.Log(i);
        massive[i].SetActive(true);
        massive[i - 1].SetActive(false);
    }

    void ToRazv()
    {
        Razv.SetActive(true);
        Knazz.SetActive(false);
    }

    void ToKnazz()
    {
        Razv.SetActive(false);
        Knazz.SetActive(true);
    }

    public GameObject DoubleDilog;
    public GameObject thisDilog;
    public GameObject Guys;
    public GameObject MainCamera;
    public GameObject NPC_Camera;
    public void Exit()
    {
        Time.timeScale = 1;
        MainCamera.SetActive(true) ;
        NPC_Camera.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Guys.SetActive(false);
        DoubleDilog.SetActive(false);
        StartCoroutine(Cid2());
        Escepe.isDilog = false;

    }
    public GameObject NextDilog;


    IEnumerator Cid2()
    
    
    {
        yield return new WaitForSeconds(2);
        NextDilog.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode .None;
        Cursor.visible = true
;        thisDilog.SetActive(false);


    }




}
