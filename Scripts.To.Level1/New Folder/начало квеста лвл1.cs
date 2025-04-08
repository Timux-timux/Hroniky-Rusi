using System.Collections;
using UnityEngine;
using UnityEngine.XR;

public class началоквесталвл1 : MonoBehaviour
{
    bool CanCLick = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CanCLick = true;
        }
        if(Input.GetKeyDown(KeyCode.Space) && CanCLick == true) 
        {
            StartCoroutine(Void());
        }
    }



    public GameObject Diak1;
    public GameObject Diak2;
    public GameObject Quest;
    public GameObject Guys;

    IEnumerator Void()
    {
        yield return new WaitForSeconds(0.19f);
        Diak1.SetActive(false);
        Diak2.SetActive(true);
        Quest.SetActive(true);
        Guys.SetActive(true);


    }
}
