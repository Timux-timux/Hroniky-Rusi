using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScoreLevel4 : MonoBehaviour
{

    [SerializeField] public TMP_Text Score;

    [SerializeField] public TMP_Text finalMark;

    string ������;

    public float ���������;

    public float �������;

     void Update()
    {
        ��������� = AllIntsLevel4.TrueAnswers / 13f;
        ������� = ���������;
        if (��������� <= 0.40) ������ = "2";
        else if (��������� > 0.40 && ��������� <=0.65) ������ = "3";
        else if (��������� > 0.65 && ��������� <= 0.8) ������ = "4";
        else if (��������� > 0.8 ) ������ = "5";



        Score.text = "���������� ������: " + AllIntsLevel4.TrueAnswers + "/13";
        finalMark.text = "�������� ������: " + ������;
    }

   


    public void Exit()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }



}