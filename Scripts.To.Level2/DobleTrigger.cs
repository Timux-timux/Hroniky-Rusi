using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobleTrigger : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerExit(Collider col)
    {
        Cube2.SetActive(true);
        Cube1.SetActive(false);

    }
}
