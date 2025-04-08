using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllIntsLevel2 : MonoBehaviour
{
    public static int TrueAnswers = 0;
    public int True;
    void Start()
    {
        MyWepenDamage.KillCaunt = 0;
        TrueAnswers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        True = TrueAnswers;
    }
}
