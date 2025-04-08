using System.Collections;
using UnityEngine;

public class ушелотжелтого : MonoBehaviour
{

    public GameObject[] Yellows;

    public GameObject Trigger;

    bool CanClick = false;

        void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)) CanClick = true;
        if(Input.GetKeyDown(KeyCode.Space) && CanClick == true)
        {
            StartCoroutine(Void());
        }
    }

        

   // void// OnTriggerExit()
   IEnumerator Void()
    {
        yield return new WaitForSeconds(0.19f);
        for(int i=0;i<Yellows.Length; i++)
        {
            Yellows[i].SetActive(false);
        }

        Trigger.GetComponent<BoxCollider>().enabled = false;
    }

}
