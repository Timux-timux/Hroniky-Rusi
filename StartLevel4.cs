using Unity.VisualScripting;
using UnityEngine;
using Unity.Collections;
using System.Collections;

public class StartLevel4 : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public Animator Camera;
    public Animator Iyes;

    public GameObject String;


    public bool CanCLick = true;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && CanCLick == true)
        {
            String.SetActive(false);
            CanCLick = false;
            OpenYies();
        }
    }


    void OpenYies()
    {

        StartCoroutine(Void());
    }

    public GameObject NextDilog;

    IEnumerator Void()
    {Camera.SetTrigger("голова");
        Iyes.SetTrigger("глаза");
         yield return new WaitForSeconds(2.7f);
        NextDilog.SetActive(true);

    }





}
