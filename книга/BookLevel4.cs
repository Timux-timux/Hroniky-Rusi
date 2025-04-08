using UnityEngine;
using Unity.Collections;
using System.Collections;
using UnityEngine.EventSystems;

public class BookLevel4 : MonoBehaviour
{
    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public GameObject book;
    public Animator animator;
   public  bool isOpen = false;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.C) && isOpen == false) OpenBook();
    }

     GameObject Player;
    GameObject Camera;

    public GameObject надпись;

    public void OpenBook()
    {
        AllIntsLevel4.BookIsOpen = true;
        надпись.SetActive(false);
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Camera.GetComponent<FPCameraController>().enabled = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<Player>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        book.SetActive(true);
        animator.SetTrigger("вверх");
        isOpen = true;
    }

    public GameObject MainCamera;
    public GameObject MCamera;

    public void CloseBook()
    {
        AllIntsLevel4.BookIsOpen = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        isOpen = false;
        animator.SetTrigger("вниз");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if(Player != MainCamera)
        Player.GetComponent<Player>().enabled = true;
        if(Camera != MCamera)
            Camera.GetComponent<FPCameraController>().enabled = true;
    }

   

}
