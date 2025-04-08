using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDilogwithNPC : MonoBehaviour
{
    public GameObject mr;
    public GameObject kn;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text42;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public Text InputText;
    [SerializeField] public InputField inputFiled;
    [SerializeField] public string MText;


    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
       
        //if (MText != "988")
       // {
       //     UnTrueAnswer();
       // }
        

    }

    public void SaveInputText()
    {
        MText = InputText.text;
        ChecingToAnswer();
    }
   
   
    public void OnButtonClick1()
    {
        Text1.SetActive(false);
        mr.SetActive(false);
        kn.SetActive(true);
        
    }
    public void OnButtonClick2()
    {
        Text2.SetActive(false);
        kn.SetActive(false);
        mr.SetActive(true);
        Text3.SetActive(true);
    }
    public void OnButtonClickifTrueAnswer()
    {
        Text4.SetActive(false);
        Text42.SetActive(false);
        Text5.SetActive(true);
        AllInts.TrueAnswers++;
    }
    public void TrueAnswer()
    {
        Text3.SetActive(false);
        Text4.SetActive(true);
    }
    public void UnTrueAnswer()
    {
        Text3.SetActive(false);
        Text42.SetActive(true);

    }
    public void ChecingToAnswer()
    {
        if(MText == "988")
            TrueAnswer  ();
        else UnTrueAnswer ();
    }
    public void OnButtonClick3()
    {
        mr.SetActive(false);
        Text5.SetActive(false);
        kn.SetActive(true);
        Text6.SetActive(true);

    }
    public void OnButtonClick4()
    {
        kn.SetActive(false);
        Text6.SetActive(false);
        mr.SetActive(true);
        Text7.SetActive(true);
    }
    public void IsEnd()
    {
        Trigger_toTM.isEnd = true;
    }

}
