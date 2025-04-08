using UnityEngine;

public class lastDilogLevel3 : MonoBehaviour
{
    public GameObject[] massive;

    int i;

    private void Start()
    {
        i = 0;
        Escepe.isDilog = true;
    }

    public void NextFraze()
    {
        i++;
        if (i == 5) { AllIntsLevel3.TrueAnswers++; toKnazz(); }
        if (i == 2) toKnazz();
        if(i==4)toFighter();
        massive[i].gameObject.SetActive(true);
        massive[i-1].gameObject.SetActive(false);
        False.SetActive(false);
    }

    public GameObject False;

   public void FalseAnswer()
    {
        toKnazz();
        massive[i].gameObject.SetActive(false);
        i++;
        False.SetActive(true);
 
    }



    public GameObject Knazz;
    public GameObject Fighter;


    void toKnazz()
    {
        Knazz.SetActive(true);
        Fighter.SetActive(false);
    }

    void toFighter()
    {
        Fighter.SetActive(true);
        Knazz.SetActive(false);
    }
}
