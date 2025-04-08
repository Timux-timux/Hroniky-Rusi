using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInROOM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider col)
    {
        AllInts.TrueAnswers = 0;
        AllInts.GuysKwant = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }
}
