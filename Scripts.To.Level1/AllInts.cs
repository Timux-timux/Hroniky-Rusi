using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllInts : MonoBehaviour
{
    public static int TrueAnswers = 0;
    public static int GuysKwant = 0;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject QuestGuys;
    [SerializeField] public Text InputText;
    //string i;
    void Start()
    {
        
    }

    
    void Update()
    {
        //i = Convert.ToString(GuysKwant);
       // InputText.text = GuysKwant.ToString() + "/5";
        if (GuysKwant == 5)
            AllGuys();

    }
    void AllGuys()
    {
        NPC1.SetActive(false);
        NPC2.SetActive(true);
        QuestGuys.SetActive(false);

    }
    //AllInts.cuantituOfRightAnswers++;
}
