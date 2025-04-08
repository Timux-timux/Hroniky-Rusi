using UnityEngine;

public class RealPressC : MonoBehaviour
{

    public GameObject GameObject1;
    public GameObject GameObject2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {   
            GameObject2.SetActive(true);
            GameObject1.SetActive(false);
        }
    }
}
