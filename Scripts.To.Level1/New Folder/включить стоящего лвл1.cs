using UnityEngine;

public class включитьстоящеголвл1 : MonoBehaviour
{
    public GameObject Runer;
    public GameObject Stayer;


    private void OnTriggerEnter(Collider other)
    {
     //   if(other.tag == "Дьяк")
        {
            Runer.SetActive(false);
            Stayer.SetActive(true);
        }

    }



}
