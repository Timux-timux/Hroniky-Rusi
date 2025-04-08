using UnityEngine;

public class dontOpen : MonoBehaviour
{
    public GameObject Audio;
    public void OnTriggerEnter(Collider other)
    {
        //Audio.SetActive(true);
    }
    public GameObject Audio2;
    public void OnTriggerExit(Collider other)
    {
       // Audio2.SetActive(false);
    }
}
