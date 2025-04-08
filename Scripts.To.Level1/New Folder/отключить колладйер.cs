using UnityEngine;

public class отключитьколладйер : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Collider.GetComponent<BoxCollider>().enabled = false;
    }

    public GameObject Collider;
}

