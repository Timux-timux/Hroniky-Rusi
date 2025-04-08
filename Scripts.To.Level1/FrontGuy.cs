using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontGuy : MonoBehaviour
{


    public GameObject Quest;

    public GameObject Guy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    { 
    Guy.SetActive(false);
        Quest.GetComponent<счетчикчеловлвл1>().Void();


    }
    }
