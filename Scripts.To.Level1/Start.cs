using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CXC: MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;

    void Start()
    {
        NPC1.SetActive(true); 
        NPC2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
