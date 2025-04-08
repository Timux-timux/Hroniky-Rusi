using UnityEngine;

public class FromChestOutDilog : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject ThisDilog;

    public GameObject ThisCube;
    public GameObject NextCube;
    public GameObject Trigger;



    private void Start()
    {
        Escepe.isDilog = true;
    }


    public void OnButtonClick()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }

    public void OnButtonClick2()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        ThisDilog.SetActive(false);
        ThisCube.SetActive(false);
        NextCube.SetActive(true);
        Trigger.SetActive(true) ;
        Escepe.isDilog = false;
    }

















}
