using UnityEngine;

public class стартлвл1 : MonoBehaviour
{




    public GameObject Dilog;
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other)
    {
        Dilog.SetActive(true);
        Trigger.SetActive(false);
    }


}
