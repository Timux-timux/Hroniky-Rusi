using UnityEngine;

public class ooouuuueeee : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;

    private void Start()
    {
        Escepe.isDilog = true;
    }
    public void NextFraze()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }

    public GameObject thisDilog;

    public void Exitt()
    {thisDilog.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        Escepe.isDilog = false;


    }
}
