using UnityEngine;

public class одинвклдругойвыкл : MonoBehaviour
{

    public GameObject Guy1;
    public GameObject Guy2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Guy1.SetActive(false);
            Guy2.SetActive(true);
        }
    }
}
