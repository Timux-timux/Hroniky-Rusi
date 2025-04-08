using UnityEngine;
using Unity.Collections;
using System.Collections;

public class TeleportationLevel4 : MonoBehaviour
{

   // public GameObject Player;

    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;
    public GameObject MainCam;

    public GameObject BlackScr;

    public GameObject BookClose;

    public void TP()
    {
        BookClose.GetComponent<BookLevel4>().CloseBook();
        
        BlackScr.SetActive(true);
        BlackScr.GetComponent<Animator>().SetTrigger("Black");
        StartCoroutine(Void());
    }
    public GameObject book;
    public GameObject EndLevel;
    IEnumerator Void()
    {
        
        yield return new WaitForSeconds(2);MainCam.SetActive(false);
        Scene3.SetActive(false);
        Scene4.SetActive(false);
        Scene1.SetActive(false);
        Scene2.SetActive(true);
        BookClose.SetActive(false);
        BlackScr.GetComponent<Animator>().SetTrigger("FronBlack");
        
        yield return new WaitForSeconds(1);
        BlackScr.SetActive(false);
        AllIntsLevel4.Scenes++;
        if (AllIntsLevel4.Scenes == 3)
            EndLevel.SetActive(true);
        book.SetActive(false);
    }

}
