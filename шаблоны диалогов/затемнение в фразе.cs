using UnityEngine;
using System.Collections;

public class затемнениевфразе : MonoBehaviour
{
    public GameObject[] Frazes;

    public bool DilogIsLast;


    public bool CanClick = true;

    public int i = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanClick == true)
        {
            i++;
            CanClick = false;
            Next_Fraze();
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
            CanClick = false;
            ExitFraomDilog();
        }
        else
        {
            Frazes[i].SetActive(true);
            Frazes[i - 1].SetActive(false);
        }
    }

    public GameObject Player;

    void ExitFraomDilog()
    {
        Text.SetActive(true);
        BlackScreen.SetActive(true);
        StartCoroutine(ActivePlayer());
    }

    public GameObject Text;

    public GameObject BlackScreen;

    public GameObject Help;

    IEnumerator ActivePlayer()
    {
        Text.GetComponent<Animator>().SetTrigger("toBlack");
        BlackScreen.GetComponent<Animator>().SetTrigger("Black");
        yield return new WaitForSeconds(2);
        Help.SetActive(false);
        Next.SetActive(true);
        Text.GetComponent<Animator>().SetTrigger("fromBlack");
        BlackScreen.GetComponent<Animator>().SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        Text.SetActive(false);
        BlackScreen.SetActive(false);
        Next.GetComponent<NextFraze>().enabled = true;
        ThisDilog.SetActive(false );

    }
}