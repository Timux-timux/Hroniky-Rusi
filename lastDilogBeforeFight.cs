using UnityEngine;
using System.Collections;
public class lastDilogBeforeFight : MonoBehaviour
{

    public GameObject[] massive;

    public GameObject FalseAnswer;

    int i;

    private void Start()
    {
        Escepe.isDilog = true;
        i = 0;
    }
    public void NextFraze()
    {
        i++;
        if (i == 4)
        {
           // Debug.Log("правда чтоли");
            AllIntsLevel3.TrueAnswers++;
        }
        massive[i].gameObject.SetActive(true);
        massive[i - 1].SetActive(false);
        FalseAnswer.SetActive(false);

    }

    public void False()
    {
        massive[i].gameObject.SetActive(false);
        i++;
        FalseAnswer.SetActive(true);
    }

    
        public GameObject BlackScreen;
    public GameObject Double;
    public void Exit()
    {
        Escepe.isDilog = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        Double.SetActive(false);
        BlackScreen.SetActive(true);
        StartCoroutine(CId());
            }

    public Animator animator;

    public GameObject MainCamera;
    public GameObject NPC_Camera;

    public GameObject NextDilog;
    public GameObject NextScene;
    public GameObject ThisScene;
    public GameObject ThisDilog;

    public GameObject Lightt;
    public GameObject NotLight;

    public GameObject Audio;
    IEnumerator CId()
    {
        animator.SetTrigger("Black");
        yield return new WaitForSeconds(1);
        Audio.SetActive(true);
        yield return new WaitForSeconds(4);
        
        NextScene.SetActive(true);
        ThisScene.SetActive(false);
        MainCamera.SetActive(false);
        NPC_Camera.SetActive(true);
        NextDilog.SetActive(true);
        Lightt.SetActive(true );
        NotLight.SetActive(false);
        animator.SetTrigger("FronBlack");
        yield return new WaitForSeconds(1);
        Audio.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        BlackScreen.SetActive(false);
        ThisDilog.SetActive(false);


    }

}
