using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    public GameObject Camera;
    public GameObject Camera1;
    public GameObject image;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        Camera.SetActive(false);
        Camera1.SetActive(true);
        image.SetActive(false);
    }
}
