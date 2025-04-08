using System.Collections;
using UnityEngine;

public class следующаясценавходвтриггер : MonoBehaviour
{

    public GameObject BlackScreen;




    private void OnTriggerEnter(Collider other)
    {
        BlackScreen.SetActive(true);
        StartCoroutine(Void());
    }

    public GameObject ThisScene;
    public GameObject NextScene;

    IEnumerator Void()
    {
        BlackScreen.GetComponent<Animator>().SetTrigger("Black");
        yield return new WaitForSeconds(2);
        ThisScene.SetActive(false);
        NextScene.SetActive(true);
        BlackScreen.GetComponent<Animator>().SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        BlackScreen.SetActive(false);
    }
}
