using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToVideo1 : MonoBehaviour
{
    public float T = 2;

    public GameObject Buttt;


    // Update is called once per frame
    void Update()
    {
        T-=Time.deltaTime;
        if (T < 0)
            Buttt.SetActive(true);
    }
}
