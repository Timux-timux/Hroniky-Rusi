using UnityEngine;

public class другойвариантначаладиалога : MonoBehaviour
{

    public GameObject Dilog;


    public GameObject Trigger;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
            other.GetComponent<Player>().enabled = false;
            Dilog.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Trigger.SetActive(false);
    }

}
