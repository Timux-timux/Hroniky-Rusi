using UnityEngine;

using System.Collections;
using TMPro;
public class DilogBeforeScene3 : MonoBehaviour
{

    public Transform Player;
    public Transform pos;

    public GameObject DilogWindow;

    public CharacterController cc;

    public GameObject Scene2;

    public GameObject MainCamera;
    public GameObject NPC_Camera;

    public GameObject ThisDilog;

    public GameObject FirstText;
    public GameObject TextYes;
    public GameObject TextNo;

    public GameObject BlackScreen;

    public Animator Animator;

 




    int Index = 0;
    bool CanClick = true;

    public GameObject[] Buttons;

    private void Up()
    {
        if (Index != 0) Index--;
        Buttons[Index].GetComponent<Animator>().SetTrigger("этот");
        Buttons[Index + 1].GetComponent<Animator>().SetTrigger("неэтот");

    }

    private void Down()
    {
        if (Index != Buttons.Length - 1) Index++;
        Buttons[Index].GetComponent<Animator>().SetTrigger("этот");
        Buttons[Index - 1].GetComponent<Animator>().SetTrigger("неэтот");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && CanClick == true)
        {
            CanClick = false;
            Up();
        }
        if (Input.GetKeyDown(KeyCode.S) && CanClick == true)
        {
            CanClick = false;
            Down();
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W)) CanClick = true;


        if (Input.GetKeyUp(KeyCode.Space)) ChouseAnswer();
    }



    void ChouseAnswer()
    {
        if (Index == 1) Exit();
        else if (Index == 0) NextScene();
    }




    public void Exit()
    {
        ThisDilog.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        MainCamera.SetActive(true);
        NPC_Camera.SetActive(false);FirstText.SetActive(true);
        TextYes.SetActive(false);
        TextNo.SetActive(false );
        // Audio2.SetActive(false);
        Escepe.isDilog = false;


    }

    
    public GameObject NextScenee;

    public void NextScene()
    {
        NextScenee.SetActive(true);
        DilogWindow.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState= CursorLockMode.Locked;
        Cursor.visible = false;
        BlackScreen.SetActive(true);
        Escepe.isDilog = false;

        StartCoroutine(Void());
        //ThisDilog.SetActive(false);
    }

    public GameObject DayLight;
    public GameObject NightLight;

    IEnumerator Void()
    {
        
        Animator.SetTrigger("Black");
        yield return new WaitForSeconds(2);
        DayLight.SetActive(false);
        NightLight.SetActive(true);
        Scene2.SetActive(false);
        cc.enabled = false;
        Player.transform.position = pos.transform.position;
        cc.enabled = true;
        NPC_Camera.SetActive(false);
        MainCamera.SetActive(true);
        Animator.SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        BlackScreen.SetActive(false);

    }
}
