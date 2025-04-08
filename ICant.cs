using UnityEngine;

public class ICant : MonoBehaviour
{
    public GameObject Window;


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Window.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Window.SetActive(false);
        }
    }
}
