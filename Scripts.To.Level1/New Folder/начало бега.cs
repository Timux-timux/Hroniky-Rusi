using System.Collections;
using UnityEngine;

public class началобега : MonoBehaviour
{


    bool canClick = false;

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKeyUp(KeyCode.Space))
            canClick = true;

        if (Input.GetKeyDown(KeyCode.Space) && canClick == true)
            StartCoroutine(Void());
    }




    public GameObject Diak;


    IEnumerator Void()
    {
        yield return new WaitForSeconds(0.19f);
        Diak.GetComponent<бежатьнаплощадь>().enabled = true;

    }


}
