using UnityEngine;

public class вводтекста : MonoBehaviour
{
    [SerializeField] public TMPro.TMP_InputField inputField;
    [SerializeField] public string MText;

    public GameObject TrueAnswer;
    public GameObject FalseAnswer;
    public GameObject ThisDilog;

    public void ChecingAnswer()
    {
        MText  = inputField.text;
        if (MText == "1380")
        {
            TrueAnswer.SetActive(true);
            AllIntsLevel3.TrueAnswers++;
            ThisDilog.SetActive(false);
        }
        else
        {
            FalseAnswer.SetActive(true);
            ThisDilog.SetActive(false);
        }
    }
}
