using UnityEngine;

public class TryAgain : MonoBehaviour
{

    public CharacterController cc;
    public GameObject Player;
    public Transform Position;
    public Transform Position2;
    public GameObject Danger;
    public GameObject Scene;

    public GameObject StayDanger;

    public GameObject Camera;
    public GameObject Dilog;

    public GameObject Panel;

    public GameObject DirLight;

    public GameObject SceneKill;

    public void PlayAgain()
    { //Player.SetActive(false);
        DirLight.GetComponent<EscLevel4>().enabled = true;
        Player.GetComponent<SetDistanationlevel4>().enabled = false;
      Danger.SetActive(false);
        Danger.transform.position = Position2.position;
        
        StayDanger.SetActive(true);


        Escepe.isDilog = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //Player.GetComponent<SetDistanationlevel4>().enabled = false;
        cc.enabled = false;
        Player.transform.position = Position.position;
        cc.enabled = true;
        Dilog.SetActive(true);
        Camera.SetActive(true);
        SceneKill.SetActive(false);
        SetDistanationlevel4.CanMore = true;
        Debug.Log("pppp00");
        Panel.SetActive(false);
    }
}
