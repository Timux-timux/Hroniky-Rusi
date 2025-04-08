using System.Collections;
using TMPro;
using UnityEngine;

public class счетчикчеловлвл1 : MonoBehaviour
{
    public TMP_Text Text;

    int count = 0;

    private void Start()
    {
        Text.text = "Отправлено людей: " + count + "/5";
    }

    public GameObject Trigger1;
    public GameObject Trigger2;

    public GameObject Quest;

    public GameObject Canvas;

  public void Void()
    {
        count++;
        Text.text = "Отправлено людей: " + count + "/5";
        if(count == 5)
        {
            Trigger1.SetActive(false);
            Trigger2.SetActive(true);
            Canvas.SetActive(true);
            StartCoroutine(Vovid());
        }
    }


    IEnumerator Vovid()
    {
        yield return new WaitForSeconds(0.5f);
        Quest.SetActive(false);
    }
}
