using UnityEngine;

public class NewStartDilog : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public GameObject Dilog;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().enabled = false;
        Dilog.SetActive(true);
    }
}
