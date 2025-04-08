using UnityEngine;

public class даталвл1 : MonoBehaviour
{
    [SerializeField] public TMPro.TMP_InputField inputField;
    [SerializeField] public string MText;

    public GameObject TrueAnswer;
    public GameObject FalseAnswer;
    public GameObject ThisDilog;

    public void ChecingAnswer()
    {
        MText = inputField.text;
        if (MText == "988")
        {
            TrueAnswer.SetActive(true);
            AllInts.TrueAnswers++;
            ThisDilog.SetActive(false);
        }
        else
        {
            FalseAnswer.SetActive(true);
            ThisDilog.SetActive(false);
        }
    }
}