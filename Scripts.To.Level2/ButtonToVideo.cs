using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToVideo : MonoBehaviour
{
    public GameObject video;
    public GameObject Button;


    public CharacterController cc;
    public Transform Player;
    public Transform Position;



    public void OnButtonClicked()
    {

        video.SetActive(false);
        Button.SetActive(false);


        cc.enabled = false;
        Player.transform.position = Position.transform.position;
        cc.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
}
