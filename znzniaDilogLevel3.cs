using UnityEngine;

using System.Collections;
public class znzniaDilogLevel3 : MonoBehaviour
{
    public GameObject[] massive;
    int i;
   void Start()
    {
        Escepe.isDilog = true;
        i = 0;
    }

    //public GameObject DilogWindow;

    public Animator Animator;

    public GameObject ThisScene;

    public GameObject NextScen;


    public GameObject Gonez2;
    public GameObject Gonez3;

    public GameObject Text1;
    public GameObject Text11;
 
        
    public GameObject Text2;
    public GameObject Text22;


    public GameObject Text3;

    public void FalseAnswer1()
    {
        Gonezz3();
        Text1.SetActive(true);
        massive[1].SetActive(false);
    }
    public void FalseAnswer11()
    {
        Gonezz2();
        Text1.SetActive(false);
        Text11.SetActive(true);
    }
    public void FalseAnswer111()
    {
        Text11.SetActive(false);
        Gonezz3();
        i = 2; massive[i].SetActive(true);
    }



    public void FalseAnswer2()
    {
        Gonezz2();
        Text2.SetActive(true);
        massive[i].SetActive(false);
    }
    public void FalseAnswer22()
    {
        Gonezz3();
        Text2.SetActive(false);
        Text22.SetActive(true);
    }
    public void FalseAnswer222()
    {
        Gonezz2();
        Text22.SetActive(false);
        
        i = 3; massive[i].SetActive(true);
    }



    public void FalseAnswer3()
    {
        
        Text3.SetActive(true);
        massive[i].SetActive(false);
    }
    public void FalseAnswer33()
    {
        Gonezz3();
        Text3.SetActive(false);
        i++;
        massive[i].SetActive(true);
    }





    public void TrueAnswer()
    {
        
        i++;
        if(i!=1)
        AllIntsLevel3.TrueAnswers++;
       // Debug.Log("מעגועû: " + AllIntsLevel3.TrueAnswers);
       // Debug.Log("לפסטג:" + i);


        if (i == 2)  Gonezz3(); 


        else if (i == 3) Gonezz2();


        else if (i == 4) Gonezz3();


        massive[i].SetActive(true);
        massive[i - 1].SetActive(false);
        
        
    }



    void Gonezz2()
    {
        Gonez2.SetActive(true);
        Gonez3.SetActive(false);

       
    }
 void Gonezz3()
        {
            Gonez3.SetActive(true);
            Gonez2.SetActive(false);
        }


    public Transform PlayerPos;
    public Transform Pos;
    public CharacterController cc;
    public GameObject BlackScreen;
    public GameObject ThisDilog;
    public GameObject MainCamera;
    public GameObject NPC_Camera;
    public GameObject DoubleThisDilog;


    public GameObject Idles1;
    public GameObject Idles2;



   public void NextScene()
    {   DoubleThisDilog.SetActive(false);
        Time.timeScale = 1;
        BlackScreen.SetActive(true);
        NextScen.SetActive(true);
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(Vid());
        Escepe.isDilog = false;

    }

    

    public GameObject NextDilog;
    IEnumerator Vid()
    {
        Animator.SetTrigger("Black");
        yield return new WaitForSeconds(2);
        ThisScene.SetActive(false);
        MainCamera.SetActive(true);
        NPC_Camera.SetActive(false);
        Idles1.SetActive(false);
        Idles2.SetActive(true);
        cc.enabled = false;
        PlayerPos.transform.position = Pos.position;
        cc.enabled = true;
        Animator.SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        BlackScreen.SetActive(false);



        Time.timeScale = 0;
        NextDilog.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ThisDilog.SetActive(false);




    }

}
