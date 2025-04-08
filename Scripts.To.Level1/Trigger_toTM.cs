using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_toTM : MonoBehaviour
{
    public Transform pos;
    public Transform Player;
    public Transform Camera;
    public GameObject Dilog;
    public GameObject Trigger;
    public GameObject Cube;
    public static bool isEnd;
    void Start()
    {
        Cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnd)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
            Dilog.SetActive(false);
Trigger.SetActive(false);
            Cube.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        pos.transform.position = Player.transform.position;
        pos.transform.position = pos.transform.position+new Vector3(2f, 0, 0);
        Player.transform.rotation = Quaternion.Euler(0, 90, 0);
        
        Time.timeScale = 0;
        Dilog.SetActive(true);
        Cube.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
