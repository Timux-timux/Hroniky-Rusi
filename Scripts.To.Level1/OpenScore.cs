using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScore : MonoBehaviour
{
    public GameObject Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
         Score.SetActive(true); 
    }
}
