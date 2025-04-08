using UnityEngine;
using UnityEngine.UI;

public class pointScript : MonoBehaviour
{
    public GameObject Slider;
    public Slider slider;
    public GameObject Light;

    public GameObject EndPlane;


    public GameObject Mongol;
    public GameObject Team;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        Slider.SetActive(true);
    }

    public GameObject Audio;
    public GameObject Audio2;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") { 
            slider.value++;

        if(slider.value == slider.maxValue)
        {
                AllIntsLevel3.points++;
                if(AllIntsLevel3.points == 7)
                {
                    Audio.SetActive(false);
                    Audio2.SetActive(true);
                    Mongol.SetActive(false);
                    Team.SetActive(true);
                    End();
                }
                transform.GetComponent<Collider>().enabled = false;
                Slider.SetActive(false);
                slider.value = 0;
                Light.SetActive(false);
        }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            slider.value = 0;
            Slider.SetActive(false);
        }
    }

    public GameObject Player;

    void End()
    {
        
        Player.GetComponent<Player>().enabled = false;
        EndPlane.SetActive(true);

    }
}
