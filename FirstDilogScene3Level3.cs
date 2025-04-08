using JetBrains.Annotations;
using UnityEngine;

public class FirstDilogScene3Level3 : MonoBehaviour
{
    public GameObject[] massive;
    int i;
    public GameObject Button1;
    public GameObject Button2;

    public GameObject Cube;
    public GameObject idlse;
    public GameObject MainCamera;
    public GameObject NPC_Camera;
    public GameObject ThisDilog;

    public GameObject[] Audio;

    private void Start()
    {
        Escepe.isDilog = true;
        i = 0;
        Audio[i].SetActive(true);
    }



    public void Next() 
    {

        i++;
        Audio[i].SetActive(true);
        Audio[i-1].SetActive(false);
        massive[i].SetActive(true);
        massive[i-1].SetActive(false);
        if (i == 2)
        {
            Button1.SetActive(false);
        }

        

    }





    public void Exit()
    {
        Escepe.isDilog = false;
        // Audio[i].SetActive(false);
        idlse.SetActive(true);
        Cube.SetActive(false);
        ThisDilog.SetActive(false);
        MainCamera.SetActive(true);
        NPC_Camera.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
