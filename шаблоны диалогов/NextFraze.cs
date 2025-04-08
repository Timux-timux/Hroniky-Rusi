using UnityEngine;
using System.Collections;

public class NextFraze : MonoBehaviour
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

        StartCoroutine(ActivePlayer());
    }

    IEnumerator ActivePlayer()
    {
        yield return new WaitForSeconds(0.2f);
       // Player.SetActive(true);
        Player.GetComponent<Player>().enabled = true;
        ThisDilog.SetActive(false);
    }
}
