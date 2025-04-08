using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLevel3 : MonoBehaviour
{

    [SerializeField] public TMP_Text Score;

    [SerializeField] public TMP_Text finalMark;

    string wre;

    private void Update()
    {
        Score.text = "Правильные ответы: " + AllIntsLevel3.TrueAnswers + "/10";

        if (AllIntsLevel3.TrueAnswers == 0)
            wre = "2";
        if (AllIntsLevel3.TrueAnswers == 1)
            wre = "2";
        if (AllIntsLevel3.TrueAnswers == 2)
            wre = "2";
        if (AllIntsLevel3.TrueAnswers == 3)
            wre = "2";
        if (AllIntsLevel3.TrueAnswers == 4)
            wre = "2";
        if (AllIntsLevel3.TrueAnswers == 5)
            wre = "3";
        if (AllIntsLevel3.TrueAnswers == 6)
            wre = "3";
        if (AllIntsLevel3.TrueAnswers == 7)
            wre = "4";
        if (AllIntsLevel3.TrueAnswers == 8)
            wre = "4";
        if (AllIntsLevel3.TrueAnswers == 9)
            wre = "5";
        if (AllIntsLevel3.TrueAnswers == 10)
            wre = "5";

        finalMark.text = "Итоговая оценка: " + wre;
    }


    public void Exit()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }



}