using UnityEngine;

public class ддата2лвл : MonoBehaviour
{
    [SerializeField] public TMPro.TMP_InputField inputField;
    [SerializeField] public string MText;

    public GameObject TrueAnswer;
    public GameObject FalseAnswer;
    public GameObject ThisDilog;

    public void ChecingAnswer()
    {
        MText = inputField.text;
        if (MText == "1242")
        {
            TrueAnswer.SetActive(true);
            AllIntsLevel2.TrueAnswers++;
            ThisDilog.SetActive(false);
        }
        else
        {
            FalseAnswer.SetActive(true);
            ThisDilog.SetActive(false);
        }
    }
}