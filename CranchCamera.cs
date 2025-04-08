using UnityEngine;
using System.Collections;
using System.Net.Sockets;
public class CranchCamera : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject npcCamera;
    public GameObject Plane;

    public GameObject BlackScreen;

    public Animator Animator;

    public GameObject layer;

    public GameObject NextDilog;

    public GameObject HandRaising;

    public GameObject Cube;

    private void Start()
    {
        //Escepe.isDilog = true;
    }

    int Index = 0;
    bool CanClick = true;

    public GameObject[] Buttons;

    private void Up()
    {
        if (Index != 0) Index--;
        Buttons[Index].GetComponent<Animator>().SetTrigger("этот");
        Buttons[Index+1].GetComponent<Animator>().SetTrigger("неэтот");

    }

    private void Down()
    {
        if (Index != Buttons.Length-1) Index++;
        Buttons[Index].GetComponent<Animator>().SetTrigger("этот");
        Buttons[Index - 1].GetComponent<Animator>().SetTrigger("неэтот");

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && CanClick == true)
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
        if (Index == 1) DontEnter();
        else if (Index == 0) Enter();
    }

    public GameObject RealPlane;

    public Transform pos;

    public void DontEnter()
    {
        layer.GetComponent<CharacterController>().enabled = false;
        layer.transform.position = pos.position;
        layer.GetComponent<CharacterController>().enabled = true;
        layer.GetComponent<Player>().enabled = true;
        
        MainCamera.SetActive(true);
        
        RealPlane.SetActive(false);
    }
    public GameObject Audio;

    public GameObject TriggerToTM;

    public void Enter()
    {
        TriggerToTM.SetActive(true);
        Escepe.isDilog = false;
        Audio.SetActive(true);
        HandRaising.SetActive(true);
        Plane.SetActive(false);
        BlackScreen.SetActive(true);
        Time.timeScale = 1;
        StartCoroutine(Void());
        Cursor.visible = false;
        Cursor.lockState= CursorLockMode.Locked;
        Cube.SetActive(false);
    }
    IEnumerator Void()
    {
        Animator.SetTrigger("Black");
        yield return new WaitForSeconds(2);
        Animator.SetTrigger("FronBlack");
        npcCamera.SetActive(false);
        MainCamera.SetActive(true);
        layer.transform.rotation = Quaternion.Euler(0f, 86, 0f);
        yield return new WaitForSeconds(1);
        BlackScreen.SetActive(false);
        NextDilog.SetActive(true);
        
        
        RealPlane.SetActive(false);
    }
}
