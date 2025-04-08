using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
        Cursor.visible = false;
        
    }

    public float totalTime = 3f;
    public Transform target;
    public float speed = 1.0f;
    public GameObject Score;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
        //if(transform.position == target.transform.position)
        //Score.SetActive(true);
        StarttIMER();
            if (totalTime < 0) { 
       Score.SetActive(true);
            Cursor.visible = true;
        }
            
            
    }
    public void StarttIMER()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
    }

}
