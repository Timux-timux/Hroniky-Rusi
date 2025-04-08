using UnityEngine;

public class fIRSTdILOG2sCENElEVEL3 : MonoBehaviour
{
    public GameObject Panel;
    public GameObject ThisCube;
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Player>().enabled = false;
        Panel.SetActive(true);
        
        
        ThisCube.SetActive(false);
    }
}
