using UnityEngine;

public class ExitHome : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject ThisDilog;

    private void Start()
    {
        Escepe.isDilog = true;
    }
    public void OnButtonCkick()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    public void OnButtonCkick2()
    {
        ThisDilog.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        Escepe.isDilog = false;
    }

}
