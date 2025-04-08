using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escepe : MonoBehaviour
{

    public static bool isDilog;

    public bool Geteet;

    public GameObject Panel;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        Geteet = isDilog;
        

    }


    public void Escape()
    {
        isDilog = false;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void Repeat()
    {
        if (isDilog == false) { 
        Panel.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;}
        else
        {
            Time.timeScale = 1;
            Panel.SetActive(false);
        }
    }
}
