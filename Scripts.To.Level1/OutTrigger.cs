using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutTrigger : MonoBehaviour
{
    public Transform Player;
    public Transform pos;
    public GameObject Dialog;

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player") 
        { 
        pos.transform.position = Player.transform.position;
        pos.transform.position = pos.transform.position+new Vector3(-4f, 2, 0);
        other.GetComponent<Player>().enabled = false;
        Dialog.SetActive(true);
       }
    }

}
