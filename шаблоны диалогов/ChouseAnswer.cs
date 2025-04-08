using UnityEngine;

public class ChouseAnswer : MonoBehaviour
{
    public GameObject[] massive1;


    public bool CanClick;

    public int i;

    private void Awake()
    {
        CanClick = false;
        i = 0;
        massive1[i].GetComponent<Animator>().SetTrigger("этот");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && CanClick == true)
        {
            CanClick = false;
            ThisButtonUp();
        }
        if (Input.GetKeyDown(KeyCode.S) && CanClick == true)
        {
            CanClick = false;
            ThisButtonDown();


        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            CanClick = true;
        }

        if (Input.GetKeyUp(KeyCode.Space) && CanClick == true)
        {
            ChouseAnswerr();
        }
    }








    void ThisButtonUp()
    {
        if (i != 0)
        {
            i--;
            massive1[i].GetComponent<Animator>().SetTrigger("этот");
            if (i != 2)
                massive1[i + 1].GetComponent<Animator>().SetTrigger("неэтот");


        }
    }

    void ThisButtonDown()
    {

        if (i != massive1.Length - 1)
        {
            i++;
            massive1[i].GetComponent<Animator>().SetTrigger("этот");
            if (i != 0)
                massive1[i - 1].GetComponent<Animator>().SetTrigger("неэтот");

        }
    }

    public GameObject ThisDilog;
    public GameObject[] NextFraze;

    void ChouseAnswerr()
    {
        NextFraze[i].SetActive(true);
        ThisDilog.SetActive(false);
    }




}