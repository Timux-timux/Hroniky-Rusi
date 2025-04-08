using UnityEngine;

public class EndQuestLevel3 : MonoBehaviour
{
 public GameObject Text1;
    public GameObject Text2;
    public GameObject ThisDilog;

    public GameObject Slider;

    private void Start()
    {
        Escepe.isDilog = true;
        Slider.SetActive(false);
    }

    public void NextFraze()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }


    public void Endd()
    {
        Escepe.isDilog = false;
        ThisDilog.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
