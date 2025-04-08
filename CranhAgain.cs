using UnityEngine;

public class CranhAgain : MonoBehaviour
{
    public GameObject Text;
    public GameObject ThisCube;
    public GameObject NextCube;


    public void OnTriggerEnter(Collider other)
    {
        Text.SetActive(true);
    }


    public void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
        ThisCube.SetActive(false);
        NextCube.SetActive(true);
    }

}
