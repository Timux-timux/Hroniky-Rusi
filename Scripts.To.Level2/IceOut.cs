using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceOut : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
       
        Canvas.SetActive(false);
    }
    public void OnTriggerExit(Collider col)
    {
        Canvas.SetActive(true);
    }
}
