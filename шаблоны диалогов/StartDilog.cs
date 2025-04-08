using UnityEngine;

public class StartDilog : MonoBehaviour
{

    public GameObject Dilog;

    public Transform position;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = position.position;
            other.GetComponent<Player>().enabled = false;
            Dilog.SetActive(true);
            
        }
    }

}
