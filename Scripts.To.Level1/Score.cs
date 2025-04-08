using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
//using UnityEditor.SceneTemplate;

public class Score : MonoBehaviour
{
    public GameObject NPC1;
    public GameObject NPC3;
    public bool time;

    public Text RightAnswers;
    public Text MyMark;
    public string z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RightAnswers.text = "Колличесвто верных ответов: " + AllInts.TrueAnswers.ToString();
        if(AllInts.TrueAnswers == 0){
            z = "2";
        }
        if (AllInts.TrueAnswers == 1)
        {
            z = "2";
        }
        if (AllInts.TrueAnswers == 2)
        {
            z = "4-";
        }
        if(AllInts.TrueAnswers == 3)
        {
            z = "5";
        }
        MyMark.text = "Итоговая оценка: " + z;
        if(time == true)
        {
            Time.timeScale = 0;
        }
    }
    public void ButtonClickedToMainMenuOut()
    {

         Time.timeScale = 0;
        // NPC1.SetActive(true);
        // NPC3.SetActive(false);
        // Trigger.SetActive(true);
          Cursor.visible = true;
         Cursor.lockState = CursorLockMode.None;
        AllInts.GuysKwant = 0;
        time = true;

        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
    }
}
