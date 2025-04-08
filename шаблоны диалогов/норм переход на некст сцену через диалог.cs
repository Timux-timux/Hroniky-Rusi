using UnityEngine;
using System.Collections;
public class нормпереходнанекстсценучерездиалог : MonoBehaviour
{
    public GameObject[] Frazes;

    public bool DilogIsLast;
    public int i = 0;

    public bool CanClick = true;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanClick == true)
        {
            if (i != Frazes.Length)
            {
                i++;
                CanClick = false;
                Next_Fraze();
            }
        }
        if (Input.GetKeyUp(KeyCode.Space) && CanClick == false)
        {
            CanClick = true;
        }
    }

    public GameObject This;
    public GameObject Next;

    public GameObject ThisDilog;

    void Next_Fraze()
    {
        if (i == Frazes.Length && !DilogIsLast)
        {
            Next.SetActive(true);
            This.SetActive(false);
        }
        else if (i >= Frazes.Length && DilogIsLast)
        {
            ExitFraomDilog();
        }
        else
        {
            Frazes[i].SetActive(true);
            Frazes[i - 1].SetActive(false);
        }
    }

    // public GameObject Player;

    void ExitFraomDilog()
    {

        StartCoroutine(ActivePlayer());
    }

    public GameObject BlckScr;
    public GameObject Scene1;
    public GameObject NExtScene;
    public GameObject вспомогательныйдиалог;
    IEnumerator ActivePlayer()
    {
        yield return new WaitForSeconds(0.2f);
        BlckScr.SetActive(true);
        BlckScr.GetComponent<Animator>().SetTrigger("Black");
        yield return new WaitForSeconds(2.5F);
        вспомогательныйдиалог.SetActive(false);
        Scene1.SetActive(false);
        NExtScene.SetActive(true);
        BlckScr.GetComponent<Animator>().SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        // Player.SetActive(true);
        BlckScr.SetActive(false);
        ThisDilog.SetActive(false);
    }
}
