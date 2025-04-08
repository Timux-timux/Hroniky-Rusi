using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScoreLevel4 : MonoBehaviour
{

    [SerializeField] public TMP_Text Score;

    [SerializeField] public TMP_Text finalMark;

    string оценка;

    public float отношение;

    public float костыль;

     void Update()
    {
        отношение = AllIntsLevel4.TrueAnswers / 13f;
        костыль = отношение;
        if (отношение <= 0.40) оценка = "2";
        else if (отношение > 0.40 && отношение <=0.65) оценка = "3";
        else if (отношение > 0.65 && отношение <= 0.8) оценка = "4";
        else if (отношение > 0.8 ) оценка = "5";



        Score.text = "Правильные ответы: " + AllIntsLevel4.TrueAnswers + "/13";
        finalMark.text = "Итоговая оценка: " + оценка;
    }

   


    public void Exit()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }



}