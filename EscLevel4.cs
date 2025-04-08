using UnityEngine;
using UnityEngine.SceneManagement;

public class EscLevel4 : MonoBehaviour
{

    public GameObject panel;    

    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.Escape)) 
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            
             
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
                          
        }

    }

    public void Close()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        if(AllIntsLevel4.BookIsOpen == false) 
        { 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        }
    }

    public void ExitMainMenu()
    {
        AllIntsLevel4.BookIsOpen = false;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
