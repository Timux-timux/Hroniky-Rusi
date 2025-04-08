using UnityEngine;

public class включениекнигилвл4 : MonoBehaviour
{

    public GameObject BookOpen;

    public GameObject надпись;

    public GameObject Trigger;

    private void OnTriggerExit(Collider other)
    {
        надпись.SetActive(true);
        BookOpen.SetActive(true);
        Trigger.SetActive(false);
    }

}
