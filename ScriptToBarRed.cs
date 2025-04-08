using UnityEngine;
using UnityEngine.UI;

public class ScriptToBarRed : MonoBehaviour
{
    public Transform Mongol;
    public Transform Player;

    public Slider slider;

    public GameObject SecondSlider;

    private void Update()
    {

        float Dist = Vector3.Distance(Player.transform.position, Mongol.transform.position);
        if (Dist <= 8)
        {
            slider.value++;
        }
        else slider.value -= 0.5f;

        if (slider.value == slider.maxValue)
            gameOver();
        
    }



    public GameObject GameOver;


    void gameOver()
    {

        GameOver.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SecondSlider.SetActive(false);







    }

    public void tryAgain()
    {

    }


}
