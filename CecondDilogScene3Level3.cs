using UnityEngine;
//using UnityEngine.UIElements;

using System.Collections;

public class CecondDilogScene3Level3 : MonoBehaviour
{
    int number;
    void Start()
    {
        Escepe.isDilog = true;
        number = 0;
    }

    public GameObject BlackScreen;
    public Animator BlackScreenAnimator;


    public GameObject RealThisDilog;

    public GameObject ThisScene;

    public GameObject NextScene;

    public GameObject MainCamera;

    public GameObject NPC_Camera;

    public GameObject[] Massive;

    public GameObject Knazz;
    public GameObject Razv;

    public GameObject Button;

    public GameObject ThisDilog;

    public CharacterController cc;

    public Transform Player;
    public Transform pos;

    public GameObject Audio;
    public void NextFraze()
    {
        number++;
        Massive[number].SetActive(true);
        Massive[number-1].SetActive(false);
        if(number == 4) { ToGonez();
            Audio.SetActive(true);
        }
        if (number == 5) 
        { ToKnazz(); 
            Button.SetActive(false);
        }
    
    }



    void ToKnazz()
    {
        Razv.SetActive(false);
        Knazz.SetActive(true);
    }
    void ToGonez()
    {
        Razv.SetActive(true);
        Knazz.SetActive(false);
    }

    public GameObject Audio2;
    public void toNextScene()
    {

        BlackScreen.SetActive(true );   
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        Audio.SetActive(false);
        Audio2.SetActive(false);
        StartCoroutine(Void());
        Escepe.isDilog = false;
















    }
    public GameObject NextDilog;

    IEnumerator Void()
    {
        BlackScreenAnimator.SetTrigger("Black");
        yield return new WaitForSeconds(2);
        ThisScene.SetActive(false);
        NextScene.SetActive(true);
        NPC_Camera.SetActive(false);
        MainCamera.SetActive(true); 
        cc.enabled = false;
        Player.transform.position = pos.position;
        cc.enabled = true;  
        ThisDilog.SetActive(false);
        BlackScreenAnimator.SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        BlackScreen.SetActive(false);
        RealThisDilog.SetActive(false);
        NextDilog.SetActive(true);

    }

}
