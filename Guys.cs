using UnityEngine;

public class Guys : MonoBehaviour
{
    public GameObject[] massive;

    int i;
    private void Start()
    {
        i = 0;
    }

    public void NextFraze()
    {
        i++;
        massive[i].SetActive(true);
        massive[i - 1].SetActive(false);
    }

    public GameObject MainCamera;
    public GameObject NPC_Camera;
    public GameObject ThisDilog;
    public void Exit()

        
    {
        massive[i].SetActive(false);
        i = 0;
        massive[i].SetActive(true);

        MainCamera.SetActive(true);
        NPC_Camera.SetActive(false);
        ThisDilog.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Escepe.isDilog = false;
        
    }

    public GameObject Guy1;
    public GameObject Guy2;

    public void toGuy1()
    {
        Guy1.SetActive(true);
        Guy2.SetActive(false);
    }
    public void toGuy2()
    {
        Guy2.SetActive(true);
        Guy1.SetActive(false);
    }
}
