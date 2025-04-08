using UnityEngine;

public class DidntBeInCerkov : MonoBehaviour
{

    public GameObject Panel;


    public void OnTriggerEnter(Collider other)
    {
        Panel.SetActive(true);
    }
    public void OnTriggerExit(Collider other)
    {
        Panel.SetActive(false);
    }
}
