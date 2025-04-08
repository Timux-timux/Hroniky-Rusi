using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;
using System.Collections;

public class ProgressBar1Level4 : MonoBehaviour
{

    public Slider progressBar;


    public float minusValue;
    public float plusValue;

    bool CanClick = true;

    void Update()
    {
        progressBar.value -= minusValue;

        if(Input.GetKeyDown(KeyCode.Space) && CanClick == true)
        {
            CanClick = false;
            BarPlasValue();
        }
        if ((Input.GetKeyUp(KeyCode.Space) && CanClick == false)){
            CanClick = true;
        }
        if(progressBar.value >= 90)
        {
            StartCoroutine(StartInim());
        }
        if(progressBar.value <=0)
        {
            StartCoroutine(StartDeathAnim());
        }


    }


    void BarPlasValue()
    {
        progressBar.value += plusValue;
    }

    public GameObject Bar;

    public Animator animator;

    public GameObject NextScene;

    public GameObject ThisScene;

    public GameObject Yies1;
    public GameObject Yies2;


    public GameObject NextCamera;

    public GameObject ThisScript;

    public GameObject Dark;


    IEnumerator ToNExtScene() 
    { 
        Yies1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Yies2.SetActive(true);
        Yies1.SetActive(false);
        ThisScene.SetActive(false);
        NextScene.SetActive(true);
        NextCamera.SetActive(true);
        Dark.SetActive(false);
        ThisScript.SetActive(false);
    }
  

    IEnumerator StartInim()
    {
        Bar.SetActive(false);
        animator.SetBool("live", true);
        yield return new WaitForSeconds(4.2f);
        StartCoroutine(ToNExtScene());
    }

    IEnumerator StartDeathAnim()
    {
        Bar.SetActive(false);
        animator.SetBool("death", true);
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(ToNExtScene());
    }
}
