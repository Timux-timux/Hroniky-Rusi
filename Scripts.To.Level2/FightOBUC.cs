using Unity.VisualScripting;
using UnityEngine;

public class FightOBUC : MonoBehaviour
{


    public GameObject Panel1; 
    public GameObject Panel2; 
    public GameObject Panel3; 
    public GameObject Panel4;
    public GameObject Obuc;








    void Start()
    {
        //Time.timeScale = 0;
    }

    // Update is called once per frame
   public void OnButtonClick()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
    }
    public void OnButtonClick1()
    {
        Panel2.SetActive(false);
        Panel3.SetActive(true);
    }

    public void OnButtonClick2()
    {
        Panel3.SetActive(false);
        Panel4.SetActive(true);
    }
    public void OnButtonClick3()
    {
        Obuc.SetActive(false);
        End();
    }



    void End()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
