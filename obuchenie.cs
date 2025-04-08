using UnityEngine;

public class obuchenie : MonoBehaviour
{

    public GameObject Slider;

    public GameObject ThisDilog;

    public GameObject[] Massive;

    int i;
    void Start()
    {
        i = 0;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Slider.SetActive(true);
    }



    public void NextFraze()
    {
        i++;
        Massive[i].SetActive(true);
        Massive[i - 1].SetActive(false);

    }

    public GameObject Audio;

    public void Play()

    {
        Audio.SetActive(true);
        ThisDilog.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }

}
