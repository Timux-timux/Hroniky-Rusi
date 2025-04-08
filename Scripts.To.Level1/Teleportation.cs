using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform pos;
    public CharacterController cc;
    public GameObject kos;
    public Transform player;
    public GameObject Quest;
    public GameObject triggerToMrWho;
    

    private void OnTriggerStay(Collider other)
    {
       kos.SetActive(false);
 cc.enabled = false;

            player.transform.position = pos.transform.position;
            cc.enabled = true;

      Quest.SetActive(false);
        //  kosIs = true;
        triggerToMrWho.SetActive(true);
        Trigger_toTM.isEnd = false;

    }

   
}